using System;
using System.Linq;

public class PhoneNumber
{
    public static string Clean(string phoneNumber)
    {
        if (string.IsNullOrWhiteSpace(phoneNumber)) throw new ArgumentNullException();

        var phoneNumberFilteredForDigits = new string(phoneNumber.ToCharArray().Where(c => char.IsDigit(c)).ToArray<char>());        

        if (phoneNumberFilteredForDigits[0] == '1')
            phoneNumberFilteredForDigits = phoneNumberFilteredForDigits.Substring(1);

        if (phoneNumberFilteredForDigits.Length != 10)
            throw new ArgumentException();

        var areaCodeInvalid = phoneNumberFilteredForDigits[0] == '0' || phoneNumberFilteredForDigits[0] == '1';
        var exchangeCodeInvalid = phoneNumberFilteredForDigits[3] == '0' || phoneNumberFilteredForDigits[3] == '1';

        if (areaCodeInvalid || exchangeCodeInvalid)
            throw new ArgumentException();

        return phoneNumberFilteredForDigits;
    }
}