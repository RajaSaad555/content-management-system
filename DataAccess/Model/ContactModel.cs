using System;

namespace DataAccess.Model
{
    // =====================================================
    // 📩 CONTACT FORM DOMAIN MODEL
    // =====================================================
    public class ContactModel
    {
        // 👤 Sender Identity:
        // - Name: Full name of the person reaching out
        // - Email: Contact address for follow-up correspondence
        public string Name { get; set; }
        public string Email { get; set; }

        // 💬 Communication:
        // - Message: The primary text or inquiry sent by the user
        public string Message { get; set; }
    }
}