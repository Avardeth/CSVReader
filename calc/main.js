$(document).ready(function(){
	var string = "";
	var result = "";
	var lastTry = "";
	var chain = "";
	var number = 0;
	var memNumber;
	var numbtn;
	
	$("button").on('click', function() {
		numbtn = '#' + $(this).attr('id');
		switch(numbtn){
			case "#result": if (string !== "")resultf(); break;
			case "#plus": if (string !== "") plus(); break;
			case "#minus": if (string !== "") minus(); break;
			case "#multiply": if (string !== "") multiply(); break;
			case "#divide": if (string !== "") divide(); break;
			case "#clear": clear(); break;
			case "#reproc": if (string !== "") reproc(); break;
			case "#memclear": if (memNumber !== null) memclear(); break;
			case "#memread": if (memNumber !== null) memread(); break;
			case "#memsave": if (string !== "") memsave(); break;
			case "#memplus": if (memNumber === null && string !== "") memNumber = 0; memplus(); break;
			case "#memminus": if (memNumber === null && string !== "") memNumber = 0; memminus(); break;
			case "#sign": if (string !== "") sign(); break;
			case "#back": if (string !== "") back(); break;
			case "#root": if (string !== "") root(); break;
			case "#percent": if (string !== "" && result !== "") percent(); break;
			case "#CE": CE();break;
			default: write(); //numbers 0-9 and comma
		}
	});
	
	function percent(){
		var num1 = parseFloat(result);
		var numper = parseFloat(string);
		numper = (num1/100)*numper;
		string = numper.toString();
		$("#text").text(string);
	}
	
	function root(){
		var num = parseFloat(string);
		string = (Math.sqrt(num)).toString();
		$("#text").text(string);
	}
	
	function CE(){
		string = "";
		$("#text").text("0");
	}
	
	function back(){
		string = string.substring(0,string.length-1);
		$("#text").text(string);
	}
	
	function sign(){
		if (string.substring(0,1) === "-")
			string = string.substring(1);
		else
			string = "-" + string;
		$("#text").text(string);
	}
	
	function memclear() {
		memNumber = null;
		$("#text").text("0");
	}
	
	function memread(){
		$("#text").text(memNumber);
	}
	
	function memsave(){
		memNumber = parseFloat(string);
		string = "";
	}
	
	function memplus(){
		memNumber += parseFloat(string);
		string = "";
	}
	
	function memminus(){
		memNumber -= parseFloat(string);
		string = "";
	}
	
	function reproc() {
		number = parseFloat(string);
		number = 1 / number;
		string = number.toString();
		$("#text").text(string);
	}
	
	function write(){
		if (result === "")
			$("#chain").empty;
		string += $(numbtn).val();
		if ($("#text").text() === "0")
			$("#text").empty();
		$("#text").text(string);
	}
	
	function plus() {
		calculationFloat();
		result = number.toString();
		chain += string + " + ";
		$("#chain").text(chain);
		string = "";
		$("#text").text(result);
		lastTry = "plus";
	}
	
	function minus() {
		calculationFloat();
		result = number.toString();
		chain += string + " - ";
		$("#chain").text(chain);
		string = "";
		$("#text").text(result);
		lastTry = "minus";
	}
	
	function multiply() {
		calculationFloat();
		result = number.toString();
		chain += string + " * ";
		$("#chain").text(chain);
		string = "";
		$("#text").text(result);
		lastTry = "multiply";
	}
	
	function divide() {
		calculationFloat();
		result = number.toString();
		chain += string + " / ";
		$("#chain").text(chain);
		string = "";
		$("#text").text(result);
		lastTry = "divide";
	}
	
	function calculationInt() {
		if (result === "")
			number = parseInt(string);
		else if (lastTry === "plus")
			number += parseInt(string);
		else if (lastTry === "minus")
			number -= parseInt(string);
		else if (lastTry === "multiply")
			number *= parseInt(string);
		else if (lastTry === "divide")
			number /= parseInt(string);
	}
	
	function calculationFloat(){
		if (result === "")
			number = parseFloat(string);
		else if (lastTry === "plus")
			number += parseFloat(string);
		else if (lastTry === "minus")
			number -= parseFloat(string);
		else if (lastTry === "multiply")
			number *= parseFloat(string);
		else if (lastTry === "divide")
			number /= parseFloat(string);
	}
	
	function resultf() {
		$("#chain").append(string);
		if (lastTry === "plus")
			result = parseFloat(result) + parseFloat(string);
		else if (lastTry === "minus")
			result = parseFloat(result) - parseFloat(string);
		else if (lastTry === "multiply")
			result = parseFloat(result) * parseFloat(string);
		else if (lastTry === "divide")
			result = parseFloat(result) / parseFloat(string);
		
		if (result === "")
			$("#text").text(string);
		else
			$("#text").text(result.toString());
		number = 0;
		result = "";
		string = "";
		chain = "";
	}
	
	function clear(){
		$("#chain").empty();
		$("#text").empty();
		$("#text").append("0");
		number = 0;
		result = "";
		string = "";
		chain = "";
	}
});