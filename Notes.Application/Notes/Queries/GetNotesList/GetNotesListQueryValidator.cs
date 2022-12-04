using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Queries.GetNotesList
{
    public class GetNotesListQueryValidator : AbstractValidator<GetNotesListQuery>
    {
        public GetNotesListQueryValidator() 
        {
            RuleFor(getNotesListQuery =>
                getNotesListQuery.UserId).NotEqual(Guid.Empty);
        }
    }
}
