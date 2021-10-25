using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FolderPermissionsExporter
{
	class rawHTML
	{
		public const string HTMLHeader = @"<!DOCTYPE html>
<html>
<meta charset = ""UTF-8"">
<head>
<style>
  /* Remove default bullets */
ul, #myUL {
  list-style-type: none;
}

	/* Remove margins and padding from the parent ul */
# myUL {
  margin: 0;
  padding: 0;
}

/* Style the caret/arrow */
.caret
{
cursor: pointer;
	user-select: none; /* Prevent text selection */
}

/* Create the caret/arrow with a unicode, and style it */
.caret::before {
content: ""\25B6"";
color: black;
display: inline-block;
	margin-right: 4px;
}

/* Rotate the caret/arrow icon when clicked on (using JavaScript) */
.caret-down::before {
transform: rotate(90deg);
}

/* Hide the nested list */
.nested
{
display: none;
margin: auto;
}


.info
{
display: none;
border-style: groove;
}

.parent
{
cursor: grab;
}

/* Show the nested list when the user clicks on the caret/arrow (with JavaScript) */
.active
{
display: block;
}

.main
{
overflow: scroll;
height: 100 %;
width: 100 %;
position: fixed;
z-index: 1;
overflow-x: hidden;
padding-top: 20px;
top: 0;
left: 0;
text-align: left;
background-color: white;
}

</style>
</head>
<body class=""main"">
 <div  id=""myUL"">";


		public const string DirHeader = @"          <li><span class=""caret""></span><a class=""parent"">(NameReplace:Me)<span class=""info"">(InfoReplace:Me)</a></span>
            <ul class=""nested"">";

		public const String SubDirHeader = @"<li class=""parent"">(NameReplace:Me)<span class=""info"">(InfoReplace:Me)</span></li>";

		public const String closeList = @"  </li>
</ul>";

		public const string ScriptFooter = @"<script>
var toggler0 = document.getElementsByClassName(""caret"");
var toggler1 = document.getElementsByClassName(""parent"");
var i;

for (i = 0; i < toggler0.length; i++) {
  toggler0[i].addEventListener(""click"", function() {
    this.parentNode.querySelector("".nested"").classList.toggle(""active"");
    this.classList.toggle(""caret-down"");
  });
}

for (i = 0; i < toggler1.length; i++) {
  toggler1[i].addEventListener(""click"", function() {
    this.querySelector("".info"").classList.toggle(""active"");
  });
}
</script>
</body>
</html>";
	}
}
