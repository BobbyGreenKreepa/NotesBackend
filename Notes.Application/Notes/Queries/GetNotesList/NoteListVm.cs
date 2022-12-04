using Notes.Application.Commons.Mappings;
using Notes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Queries.GetNotesList
{
    public class NoteListVm
    {
        public IList<NoteLookupDto> Notes { get; set; }
    }
}
