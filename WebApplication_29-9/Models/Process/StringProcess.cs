namespace WebApplication_29_9.Models.Process
{
    public class StringProcess
    {
        public string RemoveRemainingWhiteSpace(string strInput)
        {
            string strResult = "";
            //viet code de xu ly theo yeu cau cua bai toan
            //xoa bo cac khoang trang o dau va cuoi chuoi
            strInput = strInput.Trim();
            //xoa bo khoang trang con thua tring chuoi
            //int index = strInput.IndexOf(' ');
            while (strInput.IndexOf(' ') > 0)
            {
                strInput = strInput.Replace("  ", " ");
            }
            strResult = strInput;
            //tra ve du lieu sau khi xu ly
            return strResult;
        }
        public string LowerToUpper(string strInput)
        {
            string strResult;
            strResult = strInput.ToUpper();
            return strResult;
        }
        public string UpperToLower(string strInput)
        {
            string strResult;
            strResult = strInput.ToLower();
            return strResult;
        }
        public string CapitalizeOneFirstCharacter(string strInput)
        {
            return strInput.Substring(0, strInput.IndexOf(' ')).ToUpper();
        }
        public string CapitalizeFirstCharacter(string strInput)
        {
            string str1 = strInput.Substring(0, 1);
            string str2 = strInput.Substring(1, 1);
            str1 = str1.ToUpper();
            string strResult = str1 + str2;
            return strResult;
        }
        public string RemoveVietnameseCharacter(string strResult)
        {
            string[] arr1 = new string[] {"à","á","ả","ã","ạ",
                "ằ","ắ","ẳ","ẵ","ặ",
                "ầ","ấ","ẩ","ẫ","ậ",
            "đ",
            "è","é","ẻ","ẽ","ẹ",
            "ề","ế","ể","ễ","ệ",
            "ì","í","ỉ","ĩ","ị",
            "ò","ó","ỏ","õ","ọ",
            "ồ","ố","ổ","ỗ","ộ",
            "ờ","ớ","ở","ỡ","ợ",
            "ù","ú","ủ","ũ","ụ",
            "ừ","ứ","ử","ữ","ự",
            "ỳ","ý","ỷ","ỹ","ỵ",};
            string[] arr2 = new string[] {"a","a", "a", "a" , "a", "a",
            "a","a","a","a","a",
            "a","a","a","a","a",
            "e","e","e","e","e",
            "e","e","e","e","e",
            "i","i","i","i","i",
            "o","o","o","o","o",
            "o","o","o","o","o",
            "o","o","o","o","o",
            "u","u","u","u","u",
            "u","u","u","u","u",
            "y","y","y","y","y",};
            for (int i=0; i < arr1.Length; i++)
            {
                strResult = strResult.Replace(arr1[i], arr2[i]);
                strResult = strResult.Replace(arr1[i].ToUpper(),arr2[i].ToUpper());
            }
            return strResult;
        }
    }
}
