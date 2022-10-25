using System;

public class CaesarEncrypt
{
    private int alphabetCount = 26;
    
    public CaesarEncrypt()
    {
        StartEncrypt();
    }

    private char Cipher(char character, int key)
    {
        if (!char.IsLetter(character))
        {
            return character;
        }

        char characterState = char.IsUpper(character) ? 'A' : 'a';
        return (char) ((((character + key) - characterState) % alphabetCount) + characterState);
    }

    private string Encipher(string input, int key)
    {
        string output = string.Empty;

        foreach (char character in input)
            output += Cipher(character, key);

        return output;
    }

    private string Decipher(string input, int key)
    {
        return Encipher(input, alphabetCount - key);
    }

    private void StartEncrypt()
    {
        Console.WriteLine("Type information you want to encrypt:");
        string stringForEncryption = Console.ReadLine();

        Console.Write("Enter your Key");
        Console.WriteLine();
        int key = Convert.ToInt32(Console.ReadLine());

        Console.WriteLine("Encrypted Data");
        
        string encryptedData = Encipher(stringForEncryption, key);
        Console.WriteLine(encryptedData);

        Console.WriteLine("Decrypted Data:");

        string decrdyptedData = Decipher(encryptedData, key);
        Console.WriteLine(decrdyptedData);
    }
}