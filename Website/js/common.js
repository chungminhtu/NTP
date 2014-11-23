function ShowFormReport(url) {
	window.open(url,'_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1,width=800,height=500');
}
function ShowForm(url) {
	window.open(url,'_blank','location=0,toolbar=0,menubar=0,resizable=1,center=1,scrollbars=1');
}

function ShowDialogForm(url) {
	var sFeatures='dialogHeight:580px;dialogWidth:740px;status:no;center:yes;help:no;scroll:yes;resizable:yes;'
	window.showModalDialog(url,'',sFeatures);
}
function getQueryVariable(variable) {
	var query = window.location.search.substring(1);
	var vars = query.split("&");
	for (var i=0;i<vars.length;i++) {
		var pair = vars[i].split("=");
		if (pair[0]==variable) {
			return pair[1];
		}
	}
	return ""
}	
//******************************** 
//Get Node Path Text from Treeview
//********************************
function getPathText(node)
{
    var strText = "";
    var tmpNode;
    strText = node.getAttribute("TEXT");
    tmpNode = node.getParent();
    while (tmpNode!=null)
    {
        strText =strText+ " - " + tmpNode.getAttribute("TEXT");
        tmpNode = tmpNode.getParent();
    }
    return strText;
}

function getPathText_LF(node)
{
    var strText = "";
    var tmpNode;
    strText = node.getAttribute("TEXT");
    if (node.getParent()==null) return strText;
    tmpNode = node;
    while (tmpNode.getParent()!=null)
    {
        tmpNode = tmpNode.getParent();
    }
    strText =strText+ " - " + tmpNode.getAttribute("TEXT");
    return strText;
}

// Replace Function
function replaceSubstring(inputString, fromString, toString) {
   // Goes through the inputString and replaces every occurrence of fromString with toString
   var temp = inputString;
   if (fromString == "") {
      return inputString;
   }
   if (toString.indexOf(fromString) == -1) { // If the string being replaced is not a part of the replacement string (normal situation)
      while (temp.indexOf(fromString) != -1) {
         var toTheLeft = temp.substring(0, temp.indexOf(fromString));
         var toTheRight = temp.substring(temp.indexOf(fromString)+fromString.length, temp.length);
         temp = toTheLeft + toString + toTheRight;
      }
   } else { // String being replaced is part of replacement string (like "+" being replaced with "++") - prevent an infinite loop
      var midStrings = new Array("~", "`", "_", "^", "#");
      var midStringLen = 1;
      var midString = "";
      // Find a string that doesn't exist in the inputString to be used
      // as an "inbetween" string
      while (midString == "") {
         for (var i=0; i < midStrings.length; i++) {
            var tempMidString = "";
            for (var j=0; j < midStringLen; j++) { tempMidString += midStrings[i]; }
            if (fromString.indexOf(tempMidString) == -1) {
               midString = tempMidString;
               i = midStrings.length + 1;
            }
         }
      } // Keep on going until we build an "inbetween" string that doesn't exist
      // Now go through and do two replaces - first, replace the "fromString" with the "inbetween" string
      while (temp.indexOf(fromString) != -1) {
         var toTheLeft = temp.substring(0, temp.indexOf(fromString));
         var toTheRight = temp.substring(temp.indexOf(fromString)+fromString.length, temp.length);
         temp = toTheLeft + midString + toTheRight;
      }
      // Next, replace the "inbetween" string with the "toString"
      while (temp.indexOf(midString) != -1) {
         var toTheLeft = temp.substring(0, temp.indexOf(midString));
         var toTheRight = temp.substring(temp.indexOf(midString)+midString.length, temp.length);
         temp = toTheLeft + toString + toTheRight;
      }
   } // Ends the check to see if the string being replaced is part of the replacement string or not
   return temp; // Send the updated string back to the user
} // Ends the "replaceSubstring" function

//Format Date Text
function formatDateText(dateTextId)
{
	var txtDate=document.getElementById(dateTextId);
	var dateText=txtDate.value;
	if ((dateText.length!=8) || (dateText.indexOf('/')>=0)) return;
    txtDate.value = dateText.substring(0,2)+'/'+dateText.substring(2,4)+'/'+dateText.substring(4,8);
    
}
function check_int_input()
{
	if (window.event.keyCode>=48 && window.event.keyCode<=57)
		return true;
	else
		return false;
}
function check_real_input()
{
	if ((window.event.keyCode>=48 && window.event.keyCode<=57)||window.event.keyCode==46)
		return true;
	else
		return false;
}
function check_date_input()
{
	if ((window.event.keyCode>=48 && window.event.keyCode<=57)||window.event.keyCode==47)
		return true;
	else
		return false;
}
function msgCheckAll(chk){
  pe=chk.parentElement.parentElement.parentElement;
  elements=chk.form.elements;
  for(i=0;i<elements.length;i++)
    if(elements[i].type=="checkbox" && elements[i].id!=chk.id){
      if(elements[i].checked!=chk.checked && elements[i].parentElement.parentElement.parentElement==pe)
        elements[i].click();
    }
}
function msgHighlight(chk,css,highlightCss){
  if(chk.checked){
    chk.parentElement.parentElement.className=highlightCss;
  }else{
    chk.parentElement.parentElement.className=css;
  }
}

// String functions
function Trim(TRIM_VALUE){
if(TRIM_VALUE.length < 1){
return "";
}
TRIM_VALUE = RTrim(TRIM_VALUE);
TRIM_VALUE = LTrim(TRIM_VALUE);
if(TRIM_VALUE==""){
return "";
}
else{
return TRIM_VALUE;
}
} //End Function

function RTrim(VALUE){
var w_space = String.fromCharCode(32);
var v_length = VALUE.length;
var strTemp = "";
if(v_length < 0){
return "";
}
var iTemp = v_length -1;

while(iTemp > -1){
if(VALUE.charAt(iTemp) == w_space){
}
else{
strTemp = VALUE.substring(0,iTemp +1);
break;
}
iTemp = iTemp-1;

} //End While
return strTemp;

} //End Function

function LTrim(VALUE){
var w_space = String.fromCharCode(32);
if(v_length < 1){
return"";
}
var v_length = VALUE.length;
var strTemp = "";

var iTemp = 0;

while(iTemp < v_length){
if(VALUE.charAt(iTemp) == w_space){
}
else{
strTemp = VALUE.substring(iTemp,v_length);
break;
}
iTemp = iTemp + 1;
} //End While
return strTemp;
} 
//End String Functions

function doHighlight(bodyText, searchTerm)
{
  var highlightStartTag = "<font style='color:blue; background-color:yellow;font-weight:bold'>";
  var highlightEndTag = "</font>";
  var newText = "";
  var i = -1;
  var lcSearchTerm = searchTerm.toLowerCase();
  var lcBodyText = bodyText.toLowerCase();

  while (bodyText.length > 0) {
    i = lcBodyText.indexOf(lcSearchTerm, i+1);
    if (i < 0) {
      newText += bodyText;
      bodyText = "";
    } else {
        // skip anything inside an HTML tag
        if (bodyText.lastIndexOf(">", i) >= bodyText.lastIndexOf("<", i)) {
          // skip anything inside a <script> block
          if (lcBodyText.lastIndexOf("/script>", i) >= lcBodyText.lastIndexOf("<script", i)) {
            newText += bodyText.substring(0, i) + highlightStartTag + bodyText.substr(i, searchTerm.length) + highlightEndTag;
            bodyText = bodyText.substr(i + searchTerm.length);
            lcBodyText = bodyText.toLowerCase();
            i = -1;
          }
        }
    }
  }

  return newText;
}

function highlightSearchTerms(objSrc, searchText)
{
  if (typeof(objSrc.innerHTML) == "undefined") {
    return false;
  }
var bodyText = objSrc.innerHTML;

    bodyText = doHighlight(bodyText, searchText);
  objSrc.innerHTML = bodyText;
  return;// true;
}

function setupprogresssize()
{
    //var iscreenWidth;
    //var iscreenHeight;
    //iscreenWidth=document.all?document.body.clientWidth:window.innerWidth;
	//iscreenHeight=document.all?document.body.clientHeight:window.innerHeight;
    
    //alert (iscreenWidth);
    //alert (iscreenHeight);
    //document.getElementById('ModalUpdateProgress1').style.width=iscreenWidth;
	//document.getElementById('ModalUpdateProgress1').style.height=iscreenHeight;
	//document.all["waiting_overlay"].style.width = iscreenWidth;
	//document.all["waiting_overlay"].style.height = iscreenHeight;
	//alert(document.all['']);
	//ResizeWait();
	//window.onresize=ResizeWait;	
	//oldScroll=window.onscroll;
	//alert(document.all["ModalUpdateProgress1"].width);
	//alert(document.all["ModalUpdateProgress1"].height);
	//can phai remove 
	//addElement();
	
}

function getPageSize(){
	
	var xScroll, yScroll;
	
	if (window.innerHeight && window.scrollMaxY) {	
		xScroll = document.body.scrollWidth;
		yScroll = window.innerHeight + window.scrollMaxY;
	} else if (document.body.scrollHeight > document.body.offsetHeight){ // all but Explorer Mac
		xScroll = document.body.scrollWidth;
		yScroll = document.body.scrollHeight;
	} else { // Explorer Mac...would also work in Explorer 6 Strict, Mozilla and Safari
		xScroll = document.body.offsetWidth;
		yScroll = document.body.offsetHeight;
	}
	
	var windowWidth, windowHeight;
	if (self.innerHeight) {	// all except Explorer
		windowWidth = self.innerWidth;
		windowHeight = self.innerHeight;
	} else if (document.documentElement && document.documentElement.clientHeight) { // Explorer 6 Strict Mode
		windowWidth = document.documentElement.clientWidth;
		windowHeight = document.documentElement.clientHeight;
	} else if (document.body) { // other Explorers
		windowWidth = document.body.clientWidth;
		windowHeight = document.body.clientHeight;
	}	
	
	// for small pages with total height less then height of the viewport
	if(yScroll < windowHeight){
		pageHeight = windowHeight;
	} else { 
		pageHeight = yScroll;
	}

	// for small pages with total width less then width of the viewport
	if(xScroll < windowWidth){	
		pageWidth = windowWidth;
	} else {
		pageWidth = xScroll;
	}


	arrayPageSize = new Array(pageWidth,pageHeight,windowWidth,windowHeight) 
	return arrayPageSize;
}


function ResizeWait()	
{
    var objOverlay=document.getElementById('ModalUpdateProgress1');
    if (objOverlay==null) return;	
	//if (objOverlay.style.display=="none") return;	
	var arrayPageSize = getPageSize();	
    objOverlay.style.height=arrayPageSize[1]+"px";
    objOverlay.style.width=arrayPageSize[0]+"px";     
    //objOverlay.style.top = 200 + "px";
    //objOverlay.style.left = 200 + "px";         
    /*@cc_on
    @if (@_jscript_version <= 5.6)
    var objIFRAME=document.getElementById('waiting_frame');
	if (objIFRAME==null)
	{	
	objIFRAME=document.createElement("IFRAME");
	objIFRAME.setAttribute('id','waiting_frame');
	document.body.appendChild(objIFRAME);			
	}		
	objIFRAME.style.height=arrayPageSize[1]+"px";
    objIFRAME.style.width=arrayPageSize[0]+"px";
	objIFRAME.style.display="";	
    /*@end @*/ 
    //alert(objOverlay.id);
    alert(objOverlay.style.width);
    alert(objOverlay.style.height);
    
}
//Others
function addElement() {
  var ni = document.getElementById('main');
  var newdiv = document.createElement('div');
  var divIdName = 'my'+'Div';
  newdiv.setAttribute('id',divIdName);
  newdiv.innerHTML = '<a>Element Number</a>';
  ni.appendChild(newdiv);
}

///////////////////////////////////////////////////////
// The global jscript struct stores information
// about what the user is typing into the dropdown.  
// User keystrokes are constantly appended and used
// to search for corresponding dropdown items.
///////////////////////////////////////////////////////
var typeAheadData = 
{
	keyStrokes:"", // Stores user entered keystrokes.
	focusDDLId:"", // Id of the dropdown with focus.
	
	// Reset if DDL ID changes.
	ResetOnNewDDLRequest:function(id) 
	{
		if (this.focusDDLId != id) 
			{this.focusDDLId=id; this.keyStrokes="";}
	}
};

///////////////////////////////////////////////////////
// This method is called when a Type Ahead
// dropdown control fires the OnKeyDown event. When 
// called it stores keystrokes the user enters and 
// finds them in the corresponding dropdown.
///////////////////////////////////////////////////////
function TADD_OnKeyDown(tb)
{
	// Allow default dropdown control key behavior.
	if (event.ctrlKey)
		return; 
	
	// Reset typeAheadData on new DDL requests.
	typeAheadData.ResetOnNewDDLRequest(tb.id);
	
	// Capture the users key stroke.
	switch (event.keyCode)
	{
		case 38:  // Up arrow pressed.
		case 40:  // Down arrow pressed.
			// Clear saved keystrokes and allow dropdown
			// default behavior.
			typeAheadData.keyStrokes = "";
			return; 

		case 13:  // Return pressed.
			// Clear saved keystrokes and allow dropdown
			// default behavior.
			typeAheadData.keyStrokes = "";
			tb.fireEvent("onchange");
			return; 
			
		case 8:   // Backspace pressed.
			// Trim the last char from keyStrokes. 
			if (typeAheadData.keyStrokes.length > 0)
			{
				typeAheadData.keyStrokes = 
					typeAheadData.keyStrokes.substr(0, 
					    typeAheadData.keyStrokes.length-1);
			}
			// Cancel default dropdown behavior.
			event.cancelBubble = true;
			event.returnValue = false;
			break;
			
		default:
			// Convert and save users key strokes.
			var c = String.fromCharCode(event.keyCode).toLowerCase();
			if (c != null)
			{
				typeAheadData.keyStrokes += c;
			}

			// cancel default dropdown behavior.
			event.cancelBubble = true;
			event.returnValue = false;
			break;
	}
	
	// Find the captured keystrockes in the dropdown
	if (TADD_SelectItem(typeAheadData) == false)
	{
		// The keystrokes could not be found, reset.
		typeAheadData.keyStrokes = "";
		// provide status
		window.status="Not found"; 
	}
	else
	{
		// Fire the dropdown event OnChange		
		tb.fireEvent("onchange");
		// provide status
		window.status="KeyStrokes: " + typeAheadData.keyStrokes;
	}
}
///////////////////////////////////////////////////////
// This method iterates through all items in a dropdown
// looking for captured keystrokes.  Once found the
// item is selected otherwise none are selected.
///////////////////////////////////////////////////////
function TADD_SelectItem(typeAheadData)
{
	var ddl = document.getElementById(typeAheadData.focusDDLId);
	ddl.selectedIndex = -1;
	if (typeAheadData.keyStrokes.length > 0)
	{
		// Iterate through all dropdown items.
		for (i = 0; i < ddl.options.length; i++) 
		{
			if ((ddl.options[i].text.length >= 
				typeAheadData.keyStrokes.length)
			&&  (ddl.options[i].text.substr(0, 
			     typeAheadData.keyStrokes.length).toLowerCase() == 
			     typeAheadData.keyStrokes))
			{
				// Item was found, set the selected index.
				ddl.selectedIndex = i;
				return true;
			}
		}
	}
	// Item was not found, return false.
	return false;
}
