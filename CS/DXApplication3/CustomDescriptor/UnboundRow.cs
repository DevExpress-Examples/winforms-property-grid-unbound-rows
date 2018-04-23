using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.ComponentModel;

namespace DXApplication3
{
    public class UnboundRow : PropertyDescriptor
    {

        private object _MyValue;
        private readonly Type _ValueType;
        public object MyValue
        {
            get { return _MyValue; }
            set { _MyValue = value; }
        }

        public UnboundRow(string name, Type valueType)
            : base(name, null)
        {
            _ValueType = valueType;
        }


        protected UnboundRow(string name, Attribute[] attrs)
            : base(name, attrs)
        {

        }
        protected UnboundRow(MemberDescriptor descr)
            : base(descr)
        {

        }
        protected UnboundRow(MemberDescriptor descr, Attribute[] attrs)
            : base(descr, attrs)
        {

        }

        public override string Category
        {
            get
            {
                return "!Unbound rows";
            }
        }


        public override bool CanResetValue(object component)
        {
            return false;
        }

        public override Type ComponentType
        {
            get { return _ValueType; }
        }

        public override object GetValue(object component)
        {
            return MyValue;
        }

        public override bool IsReadOnly
        {
            get { return false; }
        }

        public override Type PropertyType
        {
            get { return _ValueType; }
        }

        public override void ResetValue(object component)
        {

        }

        public override void SetValue(object component, object value)
        {
            MyValue = value;
        }

        public override bool ShouldSerializeValue(object component)
        {
            return false;
        }
    }
}
