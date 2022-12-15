using System;


namespace Lemure
{
    public class Class1
    {
        #region Funcs
        public void func01(Guid id)
        {
            // do something
            func02(id);
        }
        public void func02(Guid id)
        {
            // do something
            func03(id);
        }
        public void func03(Guid id)
        {
            // do something
            func04(id);
        }
        public void func04(Guid id)
        {
            // do something
            func05(id);
        }
        public void func05(Guid id)
        {
            // do something
        }
        #endregion

        public void PegarPublicacoes()
        {
            // do something
            var correlactionId = Guid.NewGuid();
            func01(correlactionId);
        }
    }
}

/*
 PegarPublicacoes | Func01 | Func02 | Func03 | Func04 ...
 Log 000          | Log01  | Log02  | Log03  | Log04  |

hflaksdhfl
 */
