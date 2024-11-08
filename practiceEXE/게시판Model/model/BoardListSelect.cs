using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace practiceEXE.게시판Model.model
{
    public class BoardListSelect
    {
        public long boardPk {  get; set; }
        public string boardTitle { get; set; }
        public string boardWriterName { get; set; }
        public string boardContents { get; set; }
        public DateTime createdAt { get; set; }
        public DateTime? updatedAt { get; set; }
    }
}
