﻿using System;

namespace _23
{
    public class User
    {
        // はじめてインスタンスを生成する際に利用する
        public User(UserName name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            Id = new UserId(Guid.NewGuid().ToString());
            Name = name;
        }

        // インスタンスを再構成する際に利用する
        public User(UserId id, UserName name, MailAddress mailAddress = null)
        {
            if (id == null) throw new ArgumentNullException(nameof(id));
            if (name == null) throw new ArgumentNullException(nameof(name));

            Id = id;
            Name = name;
            MailAddress = mailAddress;
        }

        public UserId Id { get; }
        public UserName Name { get; private set; }
        public MailAddress MailAddress { get; private set; }

        public void ChangeName(UserName name)
        {
            if (name == null) throw new ArgumentNullException(nameof(name));

            Name = name;
        }

        public void ChangeMailAddress(MailAddress mailAddress)
        {
            if (mailAddress == null) throw new ArgumentNullException(nameof(mailAddress));

            MailAddress = mailAddress;
        }
    }
}
