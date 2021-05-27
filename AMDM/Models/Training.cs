﻿using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Linq;
using System.Threading.Tasks;

namespace AMDM.Models
{
    public class Training
    {
        [Key]
        public int Id { get; set; }

        public int TrainingTypeId { get; set; }
       
        [Display(Name = "Training type")]
        public TrainingType TrainingType { get; set; }


        [Display(Name = "Trainer id")]

        public string TrainerId { get; set; }
        public Trainer Trainer { get; set; }

        [DataType(DataType.Date)]
        public DateTime Date { get; set; }

        [DataType(DataType.Time)]
        public DateTime Time { get; set; }

        [Required]
        public string Studio { get; set; }

        [Range(1, 20)]
        public int MaxRegisterTrainees { get; set; }
        public List<Trainee> Trainees { get; set; }

    }
}