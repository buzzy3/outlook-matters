﻿using Microsoft.Office.Interop.Outlook;

namespace OutlookMatters.Mail
{
    public interface IMailExplorer
    {
        MailItem QuerySelectedMailItem();
    }
}