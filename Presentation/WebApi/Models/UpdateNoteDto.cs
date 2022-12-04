using AutoMapper;
using Notes.Application.Notes.Commands.CreateNote;
using Notes.Application.Notes.Commands.UpdateNote;

namespace Api.Models
{
    public class UpdateNoteDto
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<UpdateNoteDto, UpdateNoteCommand>()
               .ForMember(note => note.Title,
               opt => opt.MapFrom(note => note.Title))
               .ForMember(note => note.Details,
               opt => opt.MapFrom(note => note.Details))
               .ForMember(note => note.Details,
               opt => opt.MapFrom(note => note.Details));
        }
    }
}
