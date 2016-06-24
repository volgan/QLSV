using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NHUNG_THOM.Teacher
{
    public class ComboBoxItem
    {
        public string text { get; set; }
        public string value { get; set; }

        public ComboBoxItem(string text, string value)
        {
            this.text = text;
            this.value = value;
        }
    }
    public class StudentPoint
    {
        public string studentId { get; set; }
        public float point { get; set; }
        public string subjectId { get; set; }
        public bool exited { get; set; }
        public StudentPoint(string studentId, float point, string subjectId)
        {
            this.point = point;
            this.studentId = studentId;
            this.subjectId = subjectId;
            this.exited = false;
        }
    }   

    public class RestoreModel
    {
        public int index { get; set; }
        public string FileName { get; set; }
        public DateTime CreateDate { get; set; }

        public RestoreModel(int index, string FileName, DateTime CreateDate)
        {
            this.index = index;
            this.FileName = FileName;
            this.CreateDate = CreateDate;
        }
    }
}
