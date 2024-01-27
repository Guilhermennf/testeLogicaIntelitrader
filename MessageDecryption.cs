using System;
using System.Text;

public class MessageDecryption
{
    public static string DecryptMessage(string encryptedMessage)
    {
        // Convert the encrypted message to a byte array
        string[] encryptedBytes = encryptedMessage.Split(' ');
        byte[] bytes = new byte[encryptedBytes.Length];
        for (int i = 0; i < encryptedBytes.Length; i++)
        {
            bytes[i] = Convert.ToByte(encryptedBytes[i], 2);
        }

        // Invert the last two bits of each byte every 8 bits
        for (int i = 7; i < bytes.Length; i += 8)
        {
            bytes[i] ^= 0x03;
        }

        // Swap the 4 bits at the beginning with the 4 bits at the end of each byte every 4 bits
        for (int i = 3; i < bytes.Length; i += 4)
        {
            byte temp = bytes[i - 3];
            bytes[i - 3] = (byte)((bytes[i] << 4) | (bytes[i - 3] & 0x0F));
            bytes[i] = (byte)((temp >> 4) | (bytes[i] & 0xF0));
        }

        // Convert the byte array back to a string
        return Encoding.ASCII.GetString(bytes);
    }
}
