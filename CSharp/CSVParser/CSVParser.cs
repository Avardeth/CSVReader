using System;
using System.IO;
using System.Collections;
using System.Text;

namespace CSV {
	class CreateFile : CreateWords {
		public static void createFile(ArrayList wordsFile){
			string path = "result000.txt";
			try{
				if (!File.Exists(path)){
					var result = File.Create(path);
					result.Close();
					using (StreamWriter sw = new StreamWriter(path)){
						for (int i = 0; i < wordsFile.Count; i++){
							sw.WriteLine(wordsFile[i]);
						}
					}
				} else if (File.Exists(path)){
					using (StreamWriter sw = new StreamWriter(path)){
						for (int i = 0; i < wordsFile.Count; i++){
							sw.WriteLine(wordsFile[i]);
						}
					}
				}
			} catch (Exception ex) {
				Console.WriteLine(ex.ToString());
			}
		}
	}

	class ReadFile {
		public static string[] read(string File) {
			try{
			string[] lines = System.IO.File.ReadAllLines(File);
			return lines;
			} catch (FileNotFoundException){
				string[] lines = new string[1];
				return lines;
			}
		}
	}


	class CreateWords : ReadFile {
		public static ArrayList createWords(string file){
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
}