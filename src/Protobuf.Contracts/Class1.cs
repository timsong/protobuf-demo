using System;
using System.Collections.Generic;
using ProtoBuf;

namespace Protobuf.Contracts
{
    [ProtoContract]
    public class Person
    {
        [ProtoMember(1)]
        public int PersonId { get; set; }
        [ProtoMember(2)]
        public string FirstName { get; set; }
        [ProtoMember(3)]
        public string LastName { get; set; }
        [ProtoMember(4)]
        public bool IsActive { get; set; }
        [ProtoMember(5)]
        public DateTime BirthDate { get; set; }
        [ProtoMember(6, IsRequired = true)]
        public Gender Gender { get; set; }
        [ProtoMember(7)]
        public IList<Phone> PhoneNumbers { get; set; }
        [ProtoMember(8)]
        public IList<Address> Addresses { get; set; }
    }

    [ProtoContract]
    public class Address
    {
        [ProtoMember(1)]
        public string AddressLine1 { get; set; }
        [ProtoMember(2)]
        public string AddressLine2 { get; set; }
        [ProtoMember(3)]
        public string AddressLine3 { get; set; }
        [ProtoMember(4)]
        public string City { get; set; }
        [ProtoMember(5)]
        public string StateProvince { get; set; }
        [ProtoMember(6)]
        public string PostalCode { get; set; }
        [ProtoMember(7)]
        public string Country { get; set; }
        [ProtoMember(8, IsRequired =true)]
        public AddressType Type { get; set; }
    }

    [ProtoContract]
    public class Phone
    {
        [ProtoMember(1)]
        public string AreaCode { get; set; }
        [ProtoMember(2)]
        public string Number { get; set; }
        [ProtoMember(3)]
        public string Extension { get; set; }
        [ProtoMember(4, IsRequired = true)]
        public PhoneType Type { get; set; }
    }

    public enum Gender
    {
        Male,
        Female,
        Unknown
    }

    public enum AddressType
    {
        Home,
        Work,
        Other
    }

    public enum PhoneType
    {
        Home,
        Work,
        Mobile
    }
}
