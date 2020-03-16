/*
*
* Student Jaime Rodriguez
* Bellevue University
* CIS355
*
*/
/* File FileComparison.cs */
/*
* Assignment 9.3
* Purpose: Determine the file size of two different files
* After retreving the file size produce a ratio
*
* To compile the program:
* csc FileComparison.cs
*
* To execute the program:
* FileComparison.exe (.exe optional)
*
*/

using System;
using System.IO;
using static System.Console;

namespace FileComparison
{
    class Program
    {
        static void Main(string[] args)
        {
            //Create strings to minimize lenghty file name
            string fileText = "Movie Quote Text.rtf";
            string fileWord = "Movie Quote Word.docx";
          

            FileInfo rtfFile = new FileInfo(fileText);
            FileInfo docxFile = new FileInfo(fileWord);

            //Retrieve file sizes
            int sizeText = Convert.ToInt32(rtfFile.Length);
            int sizeWord = Convert.ToInt32(docxFile.Length);


            //Calcuate ratio based on file sizes above
            double textRatio = sizeText / sizeText;
            double wordRatio = sizeWord / sizeText;

            WriteLine("Size of \"Text\" (.rtf) file in bytes: {0}", sizeText);
            WriteLine("Size of \"Word\" (.docx) file in bytes: {0}", sizeWord);
            WriteLine("\nThe ratio of the files is {0}:{1}", textRatio, wordRatio);
        }
    }
}
