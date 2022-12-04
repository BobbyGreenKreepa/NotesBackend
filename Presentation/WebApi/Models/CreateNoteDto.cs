using AutoMapper;
using Notes.Application.Commons.Mappings;
using Notes.Application.Notes.Commands.CreateNote;

namespace Api.Models
{
    public class CreateNoteDto : IMapWith<CreateNoteCommand>
    {
        public string Title { get; set; }
        public string Details { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<CreateNoteDto, CreateNoteCommand>()
               .ForMember(note => note.Title,
               opt => opt.MapFrom(note => note.Title))
               .ForMember(note => note.Details,
               opt => opt.MapFrom(note => note.Details));
        }
    }
}
