using System;
using System.Collections.Generic;
using System.Linq;

public class Scripture
{
    private Reference _reference;
    private List<Word> _words;

    public Scripture(Reference reference, string text)
    {
        _reference = reference;
        _words = text.Split(' ').Select(word => new Word(word)).ToList();
    }

    public void HideRandomWords(Random rng, int numberToHide)
    {
        for (int i = 0; i < numberToHide; i++)
        {
            var wordToHide = _words.Where(w => !w.IsHidden()).OrderBy(w => rng.Next()).FirstOrDefault();
            if (wordToHide != null)
            {
                wordToHide.Hide();
            }
        }
    }

    public string GetDisplayText()
    {
        return $"{_reference.GetDisplayText()}\n{string.Join(" ", _words.Select(w => w.GetDisplayText()))}";
    }

    public bool IsCompletelyHidden()
    {
        return _words.All(w => w.IsHidden());
    }

}