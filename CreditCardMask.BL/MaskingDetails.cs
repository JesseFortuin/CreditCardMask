using System.Text;

namespace CreditCardMask.BL
{
    public class MaskingDetails : IMaskingDetails
    {
        public string Maskify(string cc)
        {
            if (cc.Length <= 4)
            {
                return cc;
            }

            StringBuilder builder = new StringBuilder(cc);

            builder.Remove(0, cc.Length - 4);

            builder.Insert(0, "#", cc.Length - 4);

            return builder.ToString();
        }
    }
}