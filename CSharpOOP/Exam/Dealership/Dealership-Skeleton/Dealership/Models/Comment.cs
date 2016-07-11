namespace Dealership.Models
{
    using System;

    using Contracts;
    using Common;

    public class Comment : IComment
    {
        private string content;

        public Comment(string content)
        {
            this.Content = content;
        }

        public string Author
        {
            get
            {
                throw new NotImplementedException();
            }

            set
            {
                throw new NotImplementedException();
            }
        }

        public string Content
        {
            get
            {
                return this.content;
            }

            private set
            {
                Validator.ValidateNull(value, Constants.CommentCannotBeNull);

                Validator.ValidateIntRange(value.Length, Constants.MinCommentLength, Constants.MaxCommentLength,
                                        string.Format(Constants.StringMustBeBetweenMinAndMax, "comment", Constants.MinCommentLength, Constants.MaxCommentLength));
                this.content = value;
            }
        }
    }
}
