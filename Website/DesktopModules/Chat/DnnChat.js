var MSG_TYPE_UNDEFINED = '0';
var MSG_TYPE_ENTER     = '1';
var MSG_TYPE_LEAVE     = '2';
var MSG_TYPE_CHAT      = '3';
var MSG_TYPE_POLL      = '4';

var XML_EMPTYMESSAGE   = '<DnnChatMessage ID="{ID}" DT="{DT}" CONTENTCDATA="{CT}" MT="{MT}" />'

var last_previous
var last_current
var count_of_msgs_displayed = 0 

function getMessageXML(text, type)
{
    //We're done pretty quick when it's just a polling message
    if(type == MSG_TYPE_POLL) {
        return '';
    }
    
    var xmlDoc = new dnn.xml.createDocument();
    // var _inputField = document.getElementById(inputField);

    // Load the result-xml document
    xmlDoc.loadXml(XML_EMPTYMESSAGE);

    // Get the message element
    var elmMsg = xmlDoc.rootNode(); //at this point we're sure there's only one
    //set the attributes
    elmMsg.setAttribute("CONTENTCDATA", text);
    //elmMsg.setAttribute("SN", msg.sender);
    elmMsg.setAttribute("MT", type);

    return xmlDoc.getXml();        
    //return retval;
}


function getChatMessageXML(inputField)
{
    var retval = getMessageXML(inputField.value, MSG_TYPE_CHAT);

    //clean the input box
    inputField.value = "";

    return retval;

}

function exitChat()
{
  oTxt.value = "[exited]"; //TODO: [LOCALIZE] Localize text
  DoChatCallBack(oTxt);
}

function receiveChatMessage(result, context)
{
    try
    {
        var dom = new dnn.xml.createDocument();
        // Load the result-xml document
        dom.loadXml(result);

        // Get the top node
        var topNode = dom.childNodes(0);
        
        var moduleID = topNode.getAttribute('MID');

        //Context is filled with "Chatwindow"
        var objDiv = context;
        
        var messageNode;
        
        //when ModileID is null, there's not much we can do
        if (moduleID == null)
        {
            return;
        }
        else  
        {
           
            last_current = topNode.childNodes(topNode.childNodeCount()-1).getAttribute('ID');
            if (last_current == last_previous)
            {
                return;
            }
            
           last_previous = last_current;
            
        }
               
        
        var text = "";
        var content = "";
        var sender = "";
        var type = MSG_TYPE_UNDEFINED;
        
        // Loop through the child elements
        for(var i=0; i<=topNode.childNodeCount()-1; i++)
        {
            messageNode = topNode.childNodes(i);
            // Get the element that the Node is about
            content = messageNode.getAttribute('CONTENTCDATA');
            sender  = messageNode.getAttribute('SN');
            type    = messageNode.getAttribute('MT');

            if (type == MSG_TYPE_CHAT) {
                var _senderSays;
                _senderSays = eval('senderText_' + moduleID);
                _senderSays = _senderSays.replace('{0}',sender);

                text += "<span class='" + eval('cssClassSender_' + moduleID) + "'>" + _senderSays + "</span><br>";
                text += "<span class='" + eval('cssClassMessage_' + moduleID) + "'>" + content + "</span><br>";
            }
            else {
                text += "<span class='" + eval('cssClassSender_' + moduleID) + "'><I>" + content + "</I></span><br>";
            }

            eval('max_msgs_displayed_'+ moduleID + ' += 1;');
            if (eval('max_msgs_displayed_'+ moduleID + ' > DisplayCapacity_'+ moduleID))
	        {
                objDiv.removeChild(objDiv.firstChild);
            }
        }

        var newDiv = document.createElement("div");
        newDiv.innerHTML = text;
        objDiv.appendChild(newDiv);
        objDiv.scrollTop = objDiv.scrollHeight;
        
    }
    catch(exc)
    {
        var newDiv = document.createElement("div");
        newDiv.innerHTML = "<span class='NormalRed'>Error: " + exc.message + "</span><br>";
        context.appendChild(newDiv);
    }
}

function receiveChatMessageError(result,context)
{
    var newDiv = document.createElement("div");
    newDiv.innerHTML = "<span class='NormalRed'>Error: " + result + "</span><br>";
    context.appendChild(newDiv);
}
