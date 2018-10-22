var contents;
$(document).ready(function() {

  $("#submit").on('click',function(){

    var file = document.getElementById("fileToRead").files[0];
    if (window.File && window.FileReader && window.FileList && window.Blob) {
    // Read files
    } else {
        alert('The File APIs are not fully supported by your browser.');
    }

    if (file){
      //console.log(file);
      var reader = new FileReader();

      reader.onload = function (evt) {
        console.log(evt);
        //document.getElementById("editor").value = evt.target.result;
        contents = evt.target.result;
        //console.log(contents);
        slicing(contents);
        /*alert( "Got the file.n"
              +"name: " + file.name + "n"
              +"type: " + file.type + "n"
              +"size: " + file.size + " bytesn"
              + "starts with: " + contents.substr(1, contents.indexOf("n"))
        );*/
      };

      reader.onerror = function (evt) {
        console.error("An error ocurred reading the file",evt);
      };

      reader.readAsText(file);
    }else {
      alert("not good");
    }
  });
});

function slicing(contents){
  var slicedText = "";
  contents = contents.replace(/(?:\r\n|\r|\n|\t)/g, '');
  for (var i = 0; i < contents.length; i++) {
      slicedText += contents[i];
  }
  document.getElementById("editor").value = slicedText;
}
