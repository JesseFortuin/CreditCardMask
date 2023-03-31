Usually when you buy something, you're asked whether your credit card number, phone number or answer to your most secret question is still correct. However, since someone could look over your shoulder, you don't want that shown on your screen. Instead, we mask it.

Your task is to write a function maskify, which changes all but the last four characters into '#'.

Examples
Kata.Maskify("4556364607935616"); // should return "############5616"
Kata.Maskify("64607935616");      // should return "#######5616"
Kata.Maskify("1");                // should return "1"
Kata.Maskify("");                 // should return ""

// "What was the name of your first pet?"
Kata.Maskify("Skippy");                                   // should return "##ippy"
Kata.Maskify("Nananananananananananananananana Batman!"); // should return "####################################man!"


----------------------------------------------------------
Solutions

    int len = cc.Length;
    if (len <=4)
      return cc;
        
    return cc.Substring(len-4).PadLeft(len, '#');

---------------

var cs = cc.ToCharArray();

            for (int i = 0; i < cc.Length - 4; i++)
            {
                cs[i] = '#';
            }

            return string.Concat(cs);

---------------

return cc.Substring(cc.Length < 4 ? 0 : cc.Length - 4).PadLeft(cc.Length, '#');