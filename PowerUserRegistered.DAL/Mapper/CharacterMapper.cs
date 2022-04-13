using PowerUserRegistered.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PowerUserRegistered.DAL.Mapper
{
    static class CharacterMapper
    {
        public static CharacterEntity ConvertToEntity(IDataRecord record)
        {
            return new CharacterEntity
            {
               Id = (int)record["Id"],   // Id = record.GetInt32(record.GetOrdinal("Id"),
               FirstName = (string)record["FirstName"],
               LastName = (string)record["LastName"],
               BirthDate = (DateTime)record["BirthDate"],
               Pv = (int)record["Pv"],
               Xp = (int)record["Xp"],
               Level = (int)record["Level"],
               Face = (string)record["Face"],
               FrontSprite = (string)record["FrontSprite"],
               BackSprite =(string)record["BackSprite"],
               FrontAttackSprite = (string)record["FrontAttackSprite"],
               BackAttackSprite =(string)record["BackAttackSprite"],
               BackKnockBackSprite = (string)record["BackKnockBackSprite"],
               FrontKnockBackSprite = (string)record["FrontKnockBackSprite"],
               Attack1 =(int)record["Attack1"],
               Attack2 =(int)record["Attack2"],
               Attack3 =(int)record["Attack3"],
               Attack4 = (int)record["Attack4"],
            };
        }
    }
}
