﻿namespace Autopick.Api.Models
{
    public class SkillModel : BaseModel
    {
        public string Name { get; set; }
        public string Description { get; set; }
        public Guid ModalityId { get; set; }
    }
}
