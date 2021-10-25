using System;
using System.IO;
using System.Security.AccessControl;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Collections.Generic;


namespace FolderPermissionsExporter
{
	public partial class MainForm : Form
	{

		public string outputFileName = Environment.GetFolderPath(Environment.SpecialFolder.MyDocuments) + "\\FolderPermissions.html";

		public MainForm()
		{
			InitializeComponent();
		}

		private void MainForm_Load(object sender, EventArgs e)
		{
			labelSelectedFolder.Text = "";
			labelStatus.Text = "";
		}

		private void buttonSelectFolder_Click(object sender, EventArgs e)
		{
			using (var fbd = new FolderBrowserDialog())
			{
				DialogResult result = fbd.ShowDialog();

				if (result == DialogResult.OK && !string.IsNullOrWhiteSpace(fbd.SelectedPath))
				{
					startCollecting(fbd.SelectedPath);

					
					MessageBox.Show("Complete! File: " + outputFileName);


					//System.Diagnostics.Process.Start(@"file:///" + outputFileName);
				}
			}
		}

		private void startCollecting(string topLevel)
		{
			writeHTMLHeader();

			DirectoryInfo dirInfo = new DirectoryInfo(topLevel);


			//writeTopLevelDir(dirInfo);

			foreach (DirectoryInfo subDir in dirInfo.GetDirectories())
			{
				try
				{
					if (subDir.GetDirectories().Length != 0)
					{
						writeTopLevelDir(subDir);
						collectSubDirs(subDir);
					}
					else 
					{ 
						writeSubDir(subDir); 
					}
					writeCloseList();
				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message);
					Application.Exit();
				}
			}

			writeHTMLFooter();

		}

		private void collectSubDirs(DirectoryInfo dir)
		{

			foreach (DirectoryInfo subDir in dir.GetDirectories())
			{
				try
				{
					if (subDir.GetDirectories().Length != 0)
					{
						writeTopLevelDir(subDir);
						collectSubDirs(subDir);
					}
					else 
					{ 
						writeSubDir(subDir);
					}

				}
				catch (Exception e)
				{
					MessageBox.Show(e.Message);
					Application.Exit();
				}
			}
			writeCloseList();
		}

		private void writeHTMLHeader()
		{
			try
			{
				using (StreamWriter sw = new StreamWriter(outputFileName))
				{
					sw.WriteLine(rawHTML.HTMLHeader);
					sw.Close();
				}
			}
			
			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		private void writeCloseList()
		{
			try
			{
				using (StreamWriter sw = File.AppendText(outputFileName))
				{
					sw.WriteLine(rawHTML.closeList);
					sw.Close();
				}
			}

			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		private void writeHTMLFooter()
		{
			try
			{
				using (StreamWriter sw = File.AppendText(outputFileName))
				{
					sw.WriteLine(rawHTML.ScriptFooter);
					sw.Close();
				}
			}

			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}

		private void writeTopLevelDir(DirectoryInfo dirInfo)
		{
			string userPermissions = "";

			try
			{
				using (StreamWriter sw = File.AppendText(outputFileName))
				{
					

					foreach (FileSystemAccessRule rule in dirInfo.GetAccessControl().GetAccessRules(true,true, typeof(System.Security.Principal.NTAccount)))
					{

						if (int.TryParse(rule.FileSystemRights.ToString(), out _)) { }
						else 
						{ 
							userPermissions = userPermissions + rule.IdentityReference.Value + ": " + rule.FileSystemRights.ToString() + @"</br>"; 
						}

					}


					sw.WriteLine(rawHTML.DirHeader.Replace("(NameReplace:Me)", dirInfo.Name).Replace("(InfoReplace:Me)", userPermissions));

					sw.Close();
				}
			}

			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}
		private void writeSubDir(DirectoryInfo dirInfo)
		{
			string userPermissions = "";

			try
			{
				using (StreamWriter sw = File.AppendText(outputFileName))
				{


					foreach (FileSystemAccessRule rule in dirInfo.GetAccessControl().GetAccessRules(true, true, typeof(System.Security.Principal.NTAccount)))
					{

						if (int.TryParse(rule.FileSystemRights.ToString(), out _)) { }
						else
						{
							userPermissions = userPermissions + rule.IdentityReference.Value + ": " + rule.FileSystemRights.ToString() + @"</br>";
						}

					}


					sw.WriteLine(rawHTML.SubDirHeader.Replace("(NameReplace:Me)", dirInfo.Name).Replace("(InfoReplace:Me)", userPermissions));

					sw.Close();
				}
			}

			catch (Exception e)
			{
				MessageBox.Show(e.Message);
			}
		}
	}
}
