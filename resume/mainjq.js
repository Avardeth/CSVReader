var xxml;
var lang;
var tagname;
$(document).ready(function(){
	$.ajax({
		type: "GET",
		url: "resume.xml",
		dataType: "xml",
		success: function(xml){ 
			header(xml),
			list(xml),
			change(xml),
			footer(xml),
			xxml = xml,
			console.log(tagname),
			console.log(xml)
		}
	});
	
	lang = 0;
	tagname = "start";
	
	$("#eng").on('click', function(){
		lang = 1;
		header(xxml);
		list(xxml);
		change(xxml);
		footer(xxml);
	});
	
	$("#hun").on('click', function(){
		lang = 0;
		header(xxml);
		list(xxml);
		change(xxml);
		footer(xxml);
	});
	
	$("li").ready(function(){
	$("#start").on('click', function(){
		tagname = "start";
		change(xxml);
		//alert("good");
	});
	
	$("#myself").on('click', function(){
		tagname = "myself";
		change(xxml);
	});
	
	$("#edu").on('click', function(){
		tagname = "edu";
		change(xxml);
	});
	
	$("#work").on('click', function(){
		tagname = "work";
		change(xxml);
	});
	
	$("#langkn").on('click', function(){
		tagname = "langkn";
		langtable(xxml);
	});
	
	$("#skill").on('click', function(){
		tagname = "skill";
		change(xxml);
	});
	
	$("#prog").on('click', function(){
		tagname = "prog";
		change(xxml);
	});
	
	$("#fin").on('click', function(){
		tagname = "fin";
		change(xxml);
	});
	
	});
});




function header(xml){
	var mainpage = $(xml).find("header:eq("+lang+")").children("mainpage").text();
	var title = $(xml).find("header:eq("+lang+")").children("title").text();
	$("#homepage").empty();
	$("#homepage").append(mainpage);
	$("#title").empty();
	$("#title").append(title);
}

function list(xml){
	var taglink = $(xml).find("list:eq("+lang+")").children();
	$(taglink).each(function(index){
		var tag = $(taglink)[index].nodeName;
		$("#"+tag+"").empty();
		$("#"+tag+"").append($(this).text());
	});
}

function change(xml){
	$("#main").empty();
	var data = "";
	if (tagname === "myself")
		data = "<div id='pic'><img src='"+$(xml).find("image").text()+"' id='portrait'/></div><div id='data'>";
	$(xml).find(tagname+":eq("+lang+")").children().each(function(){
		data += $(this).text()+"<br />";
		//console.log(tagname);
	});
	if (tagname === "myself")
		data += "</div>";
	$("#main").append(data);
}

function langtable(xml){
	$("#main").empty();
	var text = "";
	$(xml).find(tagname+":eq("+lang+")").children().slice(0,3).each(function(){
		text += $(this).text();
	});
	var table = "<table border='1px'><thead><tr>";
	$(xml).find(tagname+":eq("+lang+")").children().slice(3,6).each(function(){
		table += $(this).text();
	});
	table += "</tr></thead><tbody><tr>";
	$(xml).find(tagname+":eq("+lang+")").children().slice(6,11).each(function(){
		table += $(this).text();
	});
	table += "</tr><tr>";
	$(xml).find(tagname+":eq("+lang+")").children().slice(11,16).each(function(){
		table += $(this).text();
	});
	table += "</tr></table>";
	text += table;
	var table = "<table border='1px'><thead><tr>";
	$(xml).find(tagname+":eq("+lang+")").children().slice(16,17).each(function(){
		text += $(this).text();
	});
	$("#main").append(text);
}

function footer(xml){
	var foot = $(xml).find("footer:eq("+lang+")").children().text();
	$("#footer").empty();
	$("#footer").append(foot);
}