using DTO;
using STS.BL;
using System;
using System.Collections.Generic;
using System.Collections.ObjectModel;
using System.IdentityModel.Tokens;
using System.Linq;
using System.Security.Claims;
using System.ServiceModel;
using System.Text;
using System.Threading.Tasks;

namespace STS.Handlers
{
    public class STSUserNameHandler : UserNameSecurityTokenHandler
    {
        private UserRepository repository = new UserRepository();

        /// <summary>
        /// Gets value indicating whether tokens validation is supported.
        /// </summary>
        public override bool CanValidateToken
        {
            get
            {
                return true;
            }
        }//CanValidateToken

        /// <summary>
        /// Gets Type of token.
        /// </summary>
        public override Type TokenType
        {
            get { return typeof(UserNameSecurityToken); }
        }//TokenType

        /// <summary>
        /// Get the TokenTypeIdentifier of the token that this handler can work with.
        /// </summary>
        /// <returns>TokenTypeIdentifier array.</returns>
        public override string[] GetTokenTypeIdentifiers()
        {
            return new string[] { SecurityTokenTypes.UserName };
        }//GetTokenTypeIdentifiers

        /// <summary>
        /// Validates a token and returns its claims.
        /// </summary>
        /// <param name="token">Token to be validated.</param>
        /// <returns>Collection of claims.</returns>
        public override ReadOnlyCollection<ClaimsIdentity> ValidateToken(SecurityToken token)
        {
            var userToken = token as UserNameSecurityToken;
            if (userToken == null)
            {
                throw new FaultException("Incorrect user name or password.");
            }//if
            User dto = ValidateUserCredentials(userToken);
            return new ReadOnlyCollection<ClaimsIdentity>(ExtractClaims(userToken, dto));
        }//ValidateToken

        #region Private helper functions
        private IList<ClaimsIdentity> ExtractClaims(UserNameSecurityToken userToken, User dto)
        {
            const string Label = "UserIdentity";
            var email = string.Format("{0}@{1}.org", userToken.UserName.ToLower(), Label.ToLower());
            ClaimsIdentity outgoingIdentity = new ClaimsIdentity(Label);
            outgoingIdentity.Label = Label;
            outgoingIdentity.AddClaim(new Claim(ClaimTypes.Name, userToken.UserName));
            outgoingIdentity.AddClaim(new Claim(ClaimTypes.NameIdentifier, dto.Id.ToString()));
            outgoingIdentity.AddClaim(new Claim(ClaimTypes.Role, dto.Role));
            outgoingIdentity.AddClaim(new Claim(ClaimTypes.Email, dto.Email));
            var identityList = new List<ClaimsIdentity> { outgoingIdentity };

            return identityList;
        }

        private User ValidateUserCredentials(UserNameSecurityToken userToken)
        {
            var user = repository.ValidateUser(userToken.UserName, userToken.Password);
            if (user == null || user.Id == 0)
                throw new FaultException("Incorrect username or password.");
            return user;
        }//ValidateUserCredentials
        #endregion Private helper functions

    }
}
