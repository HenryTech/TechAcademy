function animate_string(id)   
{  
    var element = document.getElementById(id);  
    var textNode = element.childNodes[0]; // assuming no other children  
    var text = textNode.data;  
  
setInterval(function ()   
{  
 text = text[text.length - 1] + text.substring(0, text.length - 1);  
  textNode.data = text;  
}, 100);  
}  
- See more at: http://www.w3resource.com/javascript-exercises/javascript-basic-exercise-5.php#sthash.8KEkOs1S.dpuf