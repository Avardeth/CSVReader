using System;
using System.IO;
using System.Collections;


class CSVParser : WordsCreate{
	public static void Main(string[] args){
		for (int j = 0; j < args.Length; j++){
			ArrayList s = wordsCreate(args[j]);
			for (int i = 0; i < s.Count; i++){
				Console.WriteLine(s[i]);
			}
			Console.WriteLine();
		}
	}
}



class ReadFile {
	public static string[] read(string File) {
		try{
		string[] lines = System.IO.File.ReadAllLines(File);
		return lines;
		} catch (FileNotFoundException e){
			string[] lines = {e.Message};
			return lines;
		}
	}
}


class WordsCreate : ReadFile {
	public static ArrayList wordsCreate(string file){
		ArrayList words = new ArrayList();
		string[] s = read(file);
		for (int i = 0; i < s.Length; i++){
			while (s[i].Length > 0){
				string word = Separate.separate(s[i], Separator.separator);
				if (word.Length > 0)
					words.Add(word);
				if (s[i].Length > word.Length)
					s[i] = s[i].Remove(0, word.Length+1);
				else
					s[i] = s[i].Remove(0, word.Length);
			}
		}
		return words;
	}
}

class Separate {
	public static string separate(string line, char[] separator) {
		string word = "";
		for (int i = 0; i < line.Length; i++){
			bool equal = true;
			for (int j = 0; j < separator.Length; j++){
				if (line[i] == separator[j]){
					equal = false;
					break;
				}
				else if (line[i] != separator[j] && j == separator.Length-1)
					word += line[i];
			}
			if (!equal)
				break;
		}
		return word;
	}
}

class Separator {
	public static char[] separator = {',', '.', ';', '/', '\\', ' '};
}