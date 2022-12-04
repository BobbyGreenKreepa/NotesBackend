using AutoMapper;
using Notes.Application.Commons.Mappings;
using Notes.Domain;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Notes.Application.Notes.Queries.GetNoteDetails
{
    public class NoteDetailsVm : IMapWith<Note>
    {
        public Guid Id { get; set; }
        public string Title { get; set; }
        public string Details { get; set; }
        public DateTime CreationDateTime { get; set; }
        public DateTime? EditDateTime { get; set; }

        public void Mapping(Profile profile)
        {
            profile.CreateMap<Note, NoteDetailsVm>()
                .ForMember(noteVm => noteVm.Title,
                    opt => opt.MapFrom(note => note.Title))
                .ForMember(noteVm => noteVm.Details,
                    opt => opt.MapFrom(note => note.Details))
                .ForMember(noteVm => noteVm.Id,
                    opt => opt.MapFrom(note => note.Id))
                .ForMember(noteVm => noteVm.CreationDateTime,
                    opt => opt.MapFrom(note => note.CreationDateTime))
                .ForMember(noteVm => noteVm.EditDateTime,
                    opt => opt.MapFrom(note => note.EditDateTime));
        }
    }
}
