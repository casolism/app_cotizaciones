using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace backend.Datos
{
    public enum QueryOperator
    {
        /// <summary>
        /// Operador que representa a un criterio tipo "Equals"
        /// </summary>
        Equal,
        /// <summary>
        /// Operador que representa a un criterio tipo "NotEqual"
        /// </summary>
        NotEqual,
        /// <summary>
        /// Operador que representa a un criterio tipo "GreaterThan"
        /// </summary>
        GreaterThan,
        /// <summary>
        /// Operador que representa a un criterio tipo "LesserThan"
        /// </summary>
        LesserThan,
        /// <summary>
        /// Operador que representa a un criterio tipo "GreaterThanOrEqual"
        /// </summary>
        GreaterThanOrEqual,
        /// <summary>
        /// Operador que representa a un criterio tipo "LesserThanOrEqual"
        /// </summary>
        LesserThanOrEqual,
        /// <summary>
        /// Operador que representa a un criterio tipo "Like"
        /// </summary>
        Like,
        /// <summary>
        /// Operador que representa a un criterio tipo "NotLike"
        /// </summary>
        NotLike,
        /// <summary>
        /// Operador que representa a un criterio tipo "IsNull"
        /// </summary>
        IsNull,
        /// <summary>
        /// Operador que representa a un criterio tipo "IsNotNull"
        /// </summary>
        IsNotNull,
        /// <summary>
        /// Operador In
        /// </summary>
        In
    }
}