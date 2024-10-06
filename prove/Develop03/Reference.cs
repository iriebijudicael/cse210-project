using System;


class Reference
{
    // Private fields (encapsulated data)
    private string myBook;
    private int myChapter;
    private int myVerse;
    private int myEndVerse;

    // Constructor for a single verse
    public Reference(string book, int chapter, int verse)
    {
        myBook = book;
        myChapter = chapter;
        myVerse = verse;
        myEndVerse = 1; 
    }

    public Reference(string book, int chapter, int verse, int endVerse)
    {
        myBook = book;
        myChapter = chapter;
        myVerse = verse;
        myEndVerse = endVerse;
    }

    public string GetDisplayText()
    {
        if (myEndVerse == 1)
        {
            return $"{myBook} {myChapter}:{myVerse}";
        }
        else
        {
            return $"{myBook} {myChapter}:{myVerse}-{myEndVerse}";
        }
    }
}
