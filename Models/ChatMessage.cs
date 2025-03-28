﻿using ChatBotModelAPI.Models.Roles;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace ChatBotModelAPI.Models
{
    public class ChatMessage
    {
        [Key]
        public string Id { get; set; } = Guid.NewGuid().ToString();

        public DateTime Timestamp { get; set; } = DateTime.UtcNow;

        // Navigation property

        [ForeignKey("User")]
        public string UserId { get; set; }  // Foreign Key
        public virtual AppUser User { get; set; }

        public virtual ICollection<UserMessage> Messages { get; set; } = new List<UserMessage>();
        public virtual ICollection<BotReply> BotReplies { get; set; } = new List<BotReply>();
    }
}
