using System.ComponentModel.DataAnnotations;

namespace RazorPagesTestSample.Data
{
    #region snippet1
    public class Message
    {
        public const MessageMaxLength = 250;
        public int Id { get; set; }

        [Required]
        [DataType(DataType.Text)]
        [StringLength(MessageMaxLength, ErrorMessage = $"There's a {MessageMaxLength} character limit on messages. Please shorten your message.")]
        public string Text { get; set; }
    }
    #endregion
}
