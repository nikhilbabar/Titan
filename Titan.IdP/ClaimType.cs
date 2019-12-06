using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Titan.IdP
{
    public class ClaimType
    {
        /// <summary>
        /// jti
        /// The "jti" (JWT ID) claim provides a unique identifier for the JWT.
        /// The identifier value MUST be assigned in a manner that ensures that there is a 
        /// negligible probability that the same value will be accidentally assigned to a 
        /// different data object; if the application uses multiple issuers, collisions MUST 
        /// be prevented among values produced by different issuers as well.The "jti" claim 
        /// can be used to prevent the JWT from being replayed.The "jti" value is a case-sensitive string. [RFC 7519, Section 4.1.7]
        /// </summary>
        public const string JwtId = "jti";

        /// <summary>
        /// exp
        /// The "exp" (expiration time) claim identifies the expiration time on or after which 
        /// the JWT MUST NOT be accepted for processing.Implementers MAY provide for some small 
        /// leeway, usually no more than a few minutes, to account for clock skew. [RFC 7519,Section 4.1.4]
        /// </summary>
        public const string ExpirationTime = "exp";

        /// <summary>
        /// nbf
        /// The "nbf" (not before) claim identifies the time before which the JWT MUST NOT be 
        /// accepted for processing.Implementers MAY provide for some small leeway, usually no 
        /// more than a few minutes, to account for clock skew. [RFC 7519,Section 4.1.5]
        /// </summary>
        public const string NotBefore = "nbf";

        /// <summary>
        /// iat
        /// The "iat" (issued at) claim identifies the time at which the JWT was issued.This claim 
        /// can be used to determine the age of the JWT. [RFC 7519,Section 4.1.6]
        /// </summary>
        public const string IssuedAt = "iat";

        /// <summary>
        /// iss
        /// The "iss" (issuer) claim identifies the principal that issued the JWT.The processing of 
        /// this claim is generally application specific.The "iss" value is a case-sensitive string 
        /// containing a StringOrURI value. [RFC 7519, Section 4.1.1]
        /// </summary>
        public const string Issuer = "iss";

        /// <summary>
        /// aud
        /// The "aud" (audience) claim identifies the recipients that the JWT is intended for. Each 
        /// principal intended to process the JWT MUST identify itself with a value in the audience claim.
        /// If the principal processing the claim does not identify itself with a value in the "aud" claim 
        /// when this claim is present, then the JWT MUST be rejected. [RFC 7519,Section 4.1.3]
        /// </summary>
        public const string Audience = "aud";

        /// <summary>
        /// sub
        /// The "sub" (subject) claim identifies the principal that is the subject of the JWT.The claims in a 
        /// JWT are normally statements about the subject. The subject value MUST either be scoped to be locally 
        /// unique in the context of the issuer or be globally unique.The processing of this claim is generally 
        /// application specific.The "sub" value is a case-sensitive string containing a StringOrURI value. [RFC 7519, Section 4.1.2]
        /// </summary>
        public const string Subject = "sub";

        /// <summary>
        /// typ
        /// The "typ" (type) Header Parameter defined by[JWS] and[JWE] is used by JWT applications to 
        /// declare the media type[IANA.MediaTypes] of this complete JWT.
        /// This is intended for use by the JWT application when values that are not JWTs could also be 
        /// present in an application data structure that can contain a JWT object; the application can 
        /// use this value to disambiguate among the different kinds of objects that might be present.
        /// It will typically not be used by applications when it is already known that the object is a JWT.
        /// This parameter is ignored by JWT implementations; any processing of this parameter is 
        /// performed by the JWT application. If present, it is RECOMMENDED that its value be "JWT" to 
        /// indicate that this object is a JWT.
        /// While media type names are not case sensitive, it is RECOMMENDED that "JWT" always be spelled 
        /// using uppercase characters for compatibility with legacy implementations.Use of this Header Parameter is OPTIONAL.
        /// </summary>
        public const string Type = "typ";

        /// <summary>
        /// azp
        /// Authorized party - the party to which the ID Token was issued.If present, it MUST contain 
        /// the OAuth 2.0 Client ID of this party. This Claim is only needed when the ID Token has a 
        /// single audience value and that audience is different than the authorized party.
        /// It MAY be included even when the authorized party is the same as the sole audience.
        /// The azp value is a case sensitive string containing a StringOrURI value. [OpenID Connect Core 1.0, Section 2]
        /// </summary>
        public const string AuthorizedParty = "azp";

        /// <summary>
        /// nonce
        /// String value used to associate a Client session with an ID Token, and to mitigate replay attacks.
        /// The value is passed through unmodified from the Authentication Request to the ID Token.If present 
        /// in the ID Token, Clients MUST verify that the nonce Claim Value is equal to the value of the nonce 
        /// parameter sent in the Authentication Request.If present in the Authentication Request, Authorization 
        /// Servers MUST include a nonce Claim in the ID Token with the Claim Value being the nonce value sent 
        /// in the Authentication Request.Authorization Servers SHOULD perform no other processing on nonce values used.
        /// The nonce value is a case sensitive string. [OpenID Connect Core 1.0,Section 2]
        /// </summary>
        public const string Nonce = "nonce";

        /// <summary>
        /// auth_time
        /// Time when the End-User authentication occurred. [OpenID Connect Core 1.0, Section 2]
        /// </summary>
        public const string AuthenticationTime = "auth_time";

        /// <summary>
        /// session_state
        /// </summary>
        public const string SessionState = "session_state";

        /// <summary>
        /// acr
        /// Authentication Context Class Reference. 
        /// String specifying an Authentication Context Class Reference value that identifies the 
        /// Authentication Context Class that the authentication performed satisfied.The value "0" indicates the 
        /// End-User authentication did not meet the requirements of ISO/IEC 29115 [ISO29115] level 1. 
        /// Authentication using a long-lived browser cookie, for instance, is one example where the use of "level 0" is appropriate.
        /// Authentications with level 0 SHOULD NOT be used to authorize access to any resource of 
        /// any monetary value. [OpenID Connect Core 1.0,Section 2]
        /// </summary>
        public const string AuthenticationContextReference = "acr";

        /// <summary>
        /// allowed-origins
        /// </summary>
        public const string AllowedOrigins = "allowed-origins";

        /// In Keycloak, there are two types of roles: realm roles and client roles.
        /// In JWT, they are mapped to realm_access and resource_access object, respectively.
        /// realm_access is no longer included in JWT by default. It has to be configured 
        /// explicitly (this behavior has changed after 3.2.0).

        /// <summary>
        /// realm_access
        /// </summary>
        public const string RealmAccess = "realm_access";

        /// <summary>
        /// resource_access
        /// </summary>
        public const string ResourceAccess = "resource_access";

        /// <summary>
        /// scope
        /// </summary>
        public const string Scope = "scope";

        /// <summary>
        /// email_verified
        /// True if the End-User's e-mail address has been verified; otherwise false. 
        /// When this Claim Value is true, this means that the OP took affirmative steps to ensure that 
        /// this e-mail address was controlled by the End-User at the time the verification was performed. 
        /// The means by which an e-mail address is verified is context-specific, and dependent upon the 
        /// trust framework or contractual agreements within which the parties are operating. [OpenID Connect Core 1.0, Section 5.1]
        /// </summary>
        public const string EmailVerified = "email_verified";

        /// <summary>
        /// name
        /// End-User's full name in displayable form including all name parts, possibly including titles 
        /// and suffixes, ordered according to the End-User's locale and preferences. [OpenID Connect Core 1.0,Section 5.1]
        /// </summary>
        public const string Name = "name";

        /// <summary>
        /// preferred_username
        /// Shorthand name by which the End-User wishes to be referred to at the RP, such as janedoe or j.doe.
        /// This value MAY be any valid JSON string including special characters such as @, /, or whitespace. 
        /// The RP MUST NOT rely upon this value being unique, as discussed in OpenID Connect Core 1.0 Section 5.7. [OpenID Connect Core 1.0,Section 5.1]
        /// </summary>
        public const string PreferredUsername = "preferred_username";

        /// <summary>
        /// given_name
        /// Given name(s) or first name(s) of the End-User. Note that in some cultures, people can have multiple 
        /// given names; all can be present, with the names being separated by space characters. [OpenID Connect Core 1.0, Section 5.1]
        /// </summary>
        public const string GivenName = "given_name";

        /// <summary>
        /// family_name
        /// Surname(s) or last name(s) of the End-User. Note that in some cultures, people can have multiple 
        /// family names or no family name; all can be present, with the names being separated by space characters. [OpenID Connect Core 1.0, Section 5.1]
        /// </summary>
        public const string FamilyName = "family_name";

        /// <summary>
        /// email
        /// End-User's preferred e-mail address. Its value MUST conform to the RFC 5322 addr-spec syntax. 
        /// The RP MUST NOT rely upon this value being unique, as discussed in Section 5.7. The RP MUST NOT rely 
        /// upon this value being unique, as discussed in OpenID Connect Core 1.0 Section 5.7. [OpenID Connect Core 1.0, Section 5.1]
        /// </summary>
        public const string Email = "email";

    }
}
