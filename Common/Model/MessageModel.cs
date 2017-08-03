using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace Common.Model
{
    [Serializable]
    public class MessageModel
    {
        private string _msgID;
        private string _msgRecOrder;
        private string _msgCreateUser;
        private string _msgCreateDateTime;
        private string _msgSloveDept;
        private string _msgSloveUser;
        private string _msgContent;
        private int _priority;

        public string MsgID
        {
            get
            {
                return _msgID;
            }

            set
            {
                _msgID = value;
            }
        }

        public string MsgRecOrder
        {
            get
            {
                return _msgRecOrder;
            }

            set
            {
                _msgRecOrder = value;
            }
        }

        public string MsgCreateUser
        {
            get
            {
                return _msgCreateUser;
            }

            set
            {
                _msgCreateUser = value;
            }
        }

        public string MsgCreateDateTime
        {
            get
            {
                return _msgCreateDateTime;
            }

            set
            {
                _msgCreateDateTime = value;
            }
        }

        public string MsgSloveDept
        {
            get
            {
                return _msgSloveDept;
            }

            set
            {
                _msgSloveDept = value;
            }
        }

        public string MsgSloveUser
        {
            get
            {
                return _msgSloveUser;
            }

            set
            {
                _msgSloveUser = value;
            }
        }

        public string MsgContent
        {
            get
            {
                return _msgContent;
            }

            set
            {
                _msgContent = value;
            }
        }

        public int Priority { get => _priority; set => _priority = value; }
    }
}
