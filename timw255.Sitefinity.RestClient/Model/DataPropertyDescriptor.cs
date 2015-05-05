using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Reflection;
using System.Text;
using System.Threading.Tasks;

namespace timw255.Sitefinity.RestClient.Model
{
    public class DataPropertyDescriptor : PropertyDescriptor
    {
        private BitVector32 state;

        private object defaultValue;

        private PropertyInfo propInfo;

        private bool isReadOnly;

        private readonly static object noValue;

        private readonly static int defaultValueQueried;

        /// <summary>
        /// When overridden in a derived class, gets the type of the component this property is bound to.
        /// </summary>
        /// <value></value>
        /// <returns>
        /// A <see cref="T:System.Type" /> that represents the type of component this property is bound to. When the <see cref="M:System.ComponentModel.PropertyDescriptor.GetValue(System.Object)" /> or <see cref="M:System.ComponentModel.PropertyDescriptor.SetValue(System.Object,System.Object)" /> methods are invoked, the object specified might be an instance of this type.
        /// </returns>
        public override Type ComponentType
        {
            get
            {
                return this.propInfo.DeclaringType;
            }
        }

        /// <summary>
        /// Gets the default value.
        /// </summary>
        /// <value>The default value.</value>
        public object DefaultValue
        {
            get
            {
                if (!this.state[DataPropertyDescriptor.defaultValueQueried])
                {
                    this.state[DataPropertyDescriptor.defaultValueQueried] = true;
                    Attribute item = this.Attributes[typeof(DefaultValueAttribute)];
                    if (item == null)
                    {
                        this.defaultValue = DataPropertyDescriptor.noValue;
                    }
                    else
                    {
                        this.defaultValue = ((DefaultValueAttribute)item).Value;
                    }
                }
                return this.defaultValue;
            }
        }

        /// <summary>
        /// When overridden in a derived class, gets a value indicating whether this property is read-only.
        /// </summary>
        /// <value></value>
        /// <returns>true if the property is read-only; otherwise, false.
        /// </returns>
        public override bool IsReadOnly
        {
            get
            {
                return this.isReadOnly;
            }
        }

        /// <summary>
        /// When overridden in a derived class, gets the type of the property.
        /// </summary>
        /// <value></value>
        /// <returns>
        /// A <see cref="T:System.Type" /> that represents the type of the property.
        /// </returns>
        public override Type PropertyType
        {
            get
            {
                return this.propInfo.PropertyType;
            }
        }

        /// <summary>
        /// Initializes the <see cref="T:Telerik.Sitefinity.Descriptors.DataPropertyDescriptor" /> class.
        /// </summary>
        static DataPropertyDescriptor()
        {
            DataPropertyDescriptor.noValue = new object();
            DataPropertyDescriptor.defaultValueQueried = BitVector32.CreateMask();
        }

        /// <inheritdoc />
        protected DataPropertyDescriptor(string name, Attribute[] attributes)
            : base(name, attributes)
        {
        }

        /// <summary>
        /// Initializes a new instance of the <see cref="T:Telerik.Sitefinity.Descriptors.DataPropertyDescriptor" /> class.
        /// </summary>
        /// <param name="propertyInfo">The property info.</param>
        /// <param name="attributes">The attributes.</param>
        public DataPropertyDescriptor(PropertyInfo propertyInfo, Attribute[] attributes)
            : base(propertyInfo.Name, attributes)
        {
            this.state = new BitVector32();
            this.propInfo = propertyInfo;
            ReadOnlyAttribute readOnlyAttribute = (
                from a in (IEnumerable<Attribute>)attributes
                where a.GetType() == typeof(ReadOnlyAttribute)
                select a).Cast<ReadOnlyAttribute>().FirstOrDefault<ReadOnlyAttribute>();
            this.isReadOnly = !this.propInfo.CanWrite;
            if (readOnlyAttribute != null && readOnlyAttribute.IsReadOnly)
            {
                this.isReadOnly = true;
            }
        }

        /// <summary>
        /// When overridden in a derived class, returns whether resetting an object changes its value.
        /// </summary>
        /// <param name="component">The component to test for reset capability.</param>
        /// <returns>
        /// true if resetting the component changes its value; otherwise, false.
        /// </returns>
        public override bool CanResetValue(object component)
        {
            if (this.DefaultValue == DataPropertyDescriptor.noValue)
            {
                return false;
            }
            return !object.Equals(this.GetValue(component), this.DefaultValue);
        }

        private object GetPropertyOwner(object component)
        {
            ICustomTypeDescriptor customTypeDescriptor = component as ICustomTypeDescriptor;
            if (customTypeDescriptor == null)
            {
                return component;
            }
            return customTypeDescriptor.GetPropertyOwner(this);
        }

        /// <summary>
        /// When overridden in a derived class, gets the current value of the property on a component.
        /// </summary>
        /// <param name="component">The component with the property for which to retrieve the value.</param>
        /// <returns>
        /// The value of a property for a given component.
        /// </returns>
        public override object GetValue(object component)
        {
            return this.propInfo.GetValue(this.GetPropertyOwner(component), null);
        }

        /// <summary>
        /// When overridden in a derived class, resets the value for this property of the component to the default value.
        /// </summary>
        /// <param name="component">The component with the property value that is to be reset to the default value.</param>
        public override void ResetValue(object component)
        {
            if (this.DefaultValue != DataPropertyDescriptor.noValue)
            {
                this.SetValue(this.GetPropertyOwner(component), this.DefaultValue);
            }
        }

        /// <summary>
        /// When overridden in a derived class, sets the value of the component to a different value.
        /// </summary>
        /// <param name="component">The component with the property value that is to be set.</param>
        /// <param name="value">The new value.</param>
        public override void SetValue(object component, object value)
        {
            if (this.propInfo.GetSetMethod(true) != null)
            {
                if (value != null && !this.PropertyType.IsAssignableFrom(value.GetType()))
                {
                    if (this.Converter == null || !this.Converter.CanConvertFrom(value.GetType()))
                    {
                        if (!this.PropertyType.Equals(typeof(string)) || !value.GetType().Equals(typeof(Lstring)))
                        {
                            return;
                        }
                        value = value.ToString();
                    }
                    else
                    {
                        value = this.Converter.ConvertFrom(value);
                    }
                }
                this.propInfo.SetValue(this.GetPropertyOwner(component), value, null);
            }
        }

        /// <summary>
        /// When overridden in a derived class, determines a value indicating whether the value of this property needs to be persisted.
        /// </summary>
        /// <param name="component">The component with the property to be examined for persistence.</param>
        /// <returns>
        /// true if the property should be persisted; otherwise, false.
        /// </returns>
        public override bool ShouldSerializeValue(object component)
        {
            return true;
        }
    }
}
