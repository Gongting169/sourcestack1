using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.Text;

namespace CSharplearn.OO.Enum
{
    public enum ProblemStatus
    {
        [Display(Name = "待协助")]
        pending,
        [Display(Name ="协助中")]
        Assist,
        [Display(Name ="已酬谢")]
        HaveReward,
        [Display(Name ="已撤销")]
        Undo
    }
}
