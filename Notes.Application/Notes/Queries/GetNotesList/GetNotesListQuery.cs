using MediatR;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Queries.GetNotesList
{
    public class GetNotesListQuery : IRequest<NoteListVm>
    {
        public Guid UserId { get; set; }
    }
}
