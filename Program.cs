RGBToHexa(150,230,254);

 void RGBToHexa(int R, int G, int B) {
    if (R < 0 || G < 0 || B < 0)
    {
        Console.WriteLine($"An invalid input was found. Negative values are not allowed. Please enter an integer between 0 and 255.");
    }
    else if (R > 255 || G > 255 || B > 255)
    {
        Console.WriteLine($"An invalid input was found. Please enter an integer between 0 and 255.");
    }
    else {
        string hash = "#";
        int[] colorsValues = new int[3] { R, G, B };
        foreach (int color in colorsValues)
        {
            hash += IdentifyHexPosition(color);
        }
        Console.WriteLine("The Hexadecimal value is: " + hash);
    }
}

string IdentifyHexPosition(int decimalValue) {
    char[] hexMap = new char[16] { '0', '1', '2', '3', '4', '5', '6', '7', '8', '9', 'A', 'B', 'C', 'D', 'E', 'F' };
    int divisionRemainder = decimalValue % 16;
    int divisionQuotient = decimalValue / 16;
    return hexMap[divisionQuotient].ToString() + hexMap[divisionRemainder].ToString();
}
