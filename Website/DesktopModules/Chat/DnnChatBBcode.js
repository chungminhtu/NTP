var clientInfo = navigator.userAgent.toLowerCase();
var isIE = ( clientInfo.indexOf("msie") != -1 );
var isWin = ( (clientInfo.indexOf("win")!=-1) || (clientInfo.indexOf("16bit") != -1) );

function bbTag(controlID, openingTag, closingTag) {
	if(isIE && isWin) {
		bbTag_IE(controlID, openingTag, closingTag);
	}
	else {
		bbTag_nav(controlID, openingTag, closingTag);
	}
	return;
}
//First at all, there are at least 3 ways to capture the selection, according to the browser's type
//window.getSelection() // Moz, Safari
//document.getSelection// Moz, IE 5 for MAC
//document.selection.createRange().text// IE 5+ for Win

function bbTag_IE(controlID, openingTag, closingTag) {
	var txtBox = document.getElementById( controlID );
	var aSelection = document.selection.createRange().text;
	var range = txtBox.createTextRange();

	if(aSelection) {
		document.selection.createRange().text = openingTag + aSelection + closingTag;
		txtBox.focus();
		range.move('textedit');
		range.select();
	}
	else {
		var oldStringLength = range.text.length + openingTag.length;
		txtBox.value += openingTag + closingTag;
		txtBox.focus();
		range.move('character',oldStringLength);
		range.collapse(false);
		range.select();
	}
	return false;
}

function bbTag_nav(controlID, openingTag, closingTag) {
	var txtBox = document.getElementById( controlID );
	if (txtBox.selectionEnd && (txtBox.selectionEnd - txtBox.selectionStart > 0) ) {
		var preString = (txtBox.value).substring(0,txtBox.selectionStart);
		var newString = openingTag + (txtBox.value).substring(txtBox.selectionStart,txtBox.selectionEnd) + closingTag;
		var postString = (txtBox.value).substring(txtBox.selectionEnd);
		txtBox.value = preString + newString + postString;
		txtBox.focus();
	}
	else {
		var offset = txtBox.selectionStart;
		var preString = (txtBox.value).substring(0,offset);
		var newString = openingTag + closingTag;
		var postString = (txtBox.value).substring(offset);
		txtBox.value = preString + newString + postString;
		txtBox.selectionStart = offset + openingTag.length;
		txtBox.selectionEnd = offset + openingTag.length;
		txtBox.focus();
	}
	return false;
}
function ccout(theTD) {
 	 	 	}
	 	 	
 
 function ccover(theTD) {
 	var color = document.getElementById(theTD)
  	color.style.cursor='pointer'();
  	}
  	