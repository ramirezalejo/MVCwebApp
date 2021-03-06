﻿//------------------------------------------------------------------------------
// <auto-generated>
//     This code was generated by a tool.
//     Runtime Version:4.0.30319.42000
//
//     Changes to this file may cause incorrect behavior and will be lost if
//     the code is regenerated.
// </auto-generated>
//------------------------------------------------------------------------------

namespace MVCwCMS.Resources {
    using System;
    
    
    /// <summary>
    ///   A strongly-typed resource class, for looking up localized strings, etc.
    /// </summary>
    // This class was auto-generated by the StronglyTypedResourceBuilder
    // class via a tool like ResGen or Visual Studio.
    // To add or remove a member, edit your .ResX file then rerun ResGen
    // with the /str option, or rebuild your VS project.
    [global::System.CodeDom.Compiler.GeneratedCodeAttribute("System.Resources.Tools.StronglyTypedResourceBuilder", "15.0.0.0")]
    [global::System.Diagnostics.DebuggerNonUserCodeAttribute()]
    [global::System.Runtime.CompilerServices.CompilerGeneratedAttribute()]
    public class Strings_Subscription {
        
        private static global::System.Resources.ResourceManager resourceMan;
        
        private static global::System.Globalization.CultureInfo resourceCulture;
        
        [global::System.Diagnostics.CodeAnalysis.SuppressMessageAttribute("Microsoft.Performance", "CA1811:AvoidUncalledPrivateCode")]
        internal Strings_Subscription() {
        }
        
        /// <summary>
        ///   Returns the cached ResourceManager instance used by this class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Resources.ResourceManager ResourceManager {
            get {
                if (object.ReferenceEquals(resourceMan, null)) {
                    global::System.Resources.ResourceManager temp = new global::System.Resources.ResourceManager("MVCwCMS.Resources.Strings_Subscription", typeof(Strings_Subscription).Assembly);
                    resourceMan = temp;
                }
                return resourceMan;
            }
        }
        
        /// <summary>
        ///   Overrides the current thread's CurrentUICulture property for all
        ///   resource lookups using this strongly typed resource class.
        /// </summary>
        [global::System.ComponentModel.EditorBrowsableAttribute(global::System.ComponentModel.EditorBrowsableState.Advanced)]
        public static global::System.Globalization.CultureInfo Culture {
            get {
                return resourceCulture;
            }
            set {
                resourceCulture = value;
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Account details.
        /// </summary>
        public static string AccountDetails {
            get {
                return ResourceManager.GetString("AccountDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;h2&gt;It seems your verification link has been already used.&lt;/h2&gt;
        ///&lt;p&gt;If you have any enquiries please don&apos;t hesitate to contact us.&lt;/p&gt;.
        /// </summary>
        public static string ActivationKeyAlreadyUsed {
            get {
                return ResourceManager.GetString("ActivationKeyAlreadyUsed", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;h2&gt;It seems your verification link is not valid.&lt;/h2&gt;
        ///&lt;p&gt;Please try again by copying and pasting your verification link into your web browser.&lt;/p&gt;
        ///&lt;p&gt;If it still doesn&apos;t work please don&apos;t hesitate to contact us to report this issue.&lt;/p&gt;.
        /// </summary>
        public static string ActivationKeyInvalid {
            get {
                return ResourceManager.GetString("ActivationKeyInvalid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;h2&gt;Thanks for completing your registration!&lt;/h2&gt;
        ///&lt;p&gt;Now you will be able to use all features of our website.&lt;/p&gt;.
        /// </summary>
        public static string ActivationKeySuccess {
            get {
                return ResourceManager.GetString("ActivationKeySuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Dear {$FirstName},&lt;/p&gt;
        ///&lt;p&gt;{$SiteName} received a request to reset your password. To proceed please click the following link:&lt;/p&gt;
        ///&lt;p&gt;&amp;nbsp;&amp;nbsp;&lt;a href=&quot;{$PasswordResetUrl}&quot;&gt;{$PasswordResetUrl}&lt;/a&gt;&lt;/p&gt;
        ///&lt;p&gt;If you are unable to click the link above, copy and paste it into your web browser. If you are unable to do that, don&apos;t hesitate to contact us through our website.&lt;/p&gt;
        ///&lt;p&gt;&amp;nbsp;&lt;/p&gt;
        ///&lt;p&gt;Best regards,&lt;/p&gt;
        ///&lt;p&gt;The team at {$SiteName}&lt;/p&gt;
        ///&lt;p&gt;{$Url}&lt;/p&gt;
        ///&lt;p&gt;&amp;nbsp;&lt;/p&gt;
        ///&lt;p&gt;&amp;nbsp;&lt;/p&gt;
        ///&lt;p&gt;Please note: Th [rest of string was truncated]&quot;;.
        /// </summary>
        public static string EmailPwForgotBody {
            get {
                return ResourceManager.GetString("EmailPwForgotBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Password reset for {$SiteName}.
        /// </summary>
        public static string EmailPwForgotSubject {
            get {
                return ResourceManager.GetString("EmailPwForgotSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Here is the latest subscription to {$Url}:&lt;/p&gt;
        ///&lt;table style=&quot;border-collapse:collapse;border-spacing:0;width:100%&quot;&gt;
        ///  &lt;tr&gt;
        ///    &lt;th style=&quot;border:1px #bbb solid;padding:10px;text-align:left;vertical-align:top;width:1%;white-space:nowrap;&quot;&gt;Subscription email:&lt;/th&gt;
        ///    &lt;td style=&quot;border:1px #bbb solid;padding:10px;vertical-align:top;&quot;&gt;{$subscriptionEmail}&lt;/td&gt;
        ///  &lt;/tr&gt;
        ///  &lt;tr&gt;
        ///    &lt;th style=&quot;border:1px #bbb solid;padding:10px;text-align:left;vertical-align:top;width:1%;white-space:nowrap;&quot;&gt;IP address:&lt; [rest of string was truncated]&quot;;.
        /// </summary>
        public static string EmailSubscriptionAddedBody {
            get {
                return ResourceManager.GetString("EmailSubscriptionAddedBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription added to {$Url}.
        /// </summary>
        public static string EmailSubscriptionAddedSubject {
            get {
                return ResourceManager.GetString("EmailSubscriptionAddedSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;p&gt;Dear {$FirstName},&lt;/p&gt;
        ///&lt;p&gt;{$SiteName} received a request to create an account for you. To verify your email and start using your account, please click the following link:&lt;/p&gt;
        ///&lt;p&gt;&amp;nbsp;&amp;nbsp;&lt;a href=&quot;{$VerificationUrl}&quot;&gt;{$VerificationUrl}&lt;/a&gt;&lt;/p&gt;
        ///&lt;p&gt;If you are unable to click the link above, copy and paste it into your web browser. If you are unable to do that, don&apos;t hesitate to contact us through our website.&lt;/p&gt;
        ///&lt;p&gt;&amp;nbsp;&lt;/p&gt;
        ///&lt;p&gt;Best regards,&lt;/p&gt;
        ///&lt;p&gt;The team at {$SiteName}&lt;/p&gt;
        ///&lt;p&gt;{$Url}&lt;/p&gt;
        ///&lt;p&gt;&amp; [rest of string was truncated]&quot;;.
        /// </summary>
        public static string EmailVerifyAccountBody {
            get {
                return ResourceManager.GetString("EmailVerifyAccountBody", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Please complete your registration to {$SiteName}.
        /// </summary>
        public static string EmailVerifyAccountSubject {
            get {
                return ResourceManager.GetString("EmailVerifyAccountSubject", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to It seems your password reset link is not valid.
        ///Please try again by copying and pasting your password reset link into your web browser.
        ///If it still doesn&apos;t work please don&apos;t hesitate to contact us to report this issue..
        /// </summary>
        public static string PasswordResetUrlNotValid {
            get {
                return ResourceManager.GetString("PasswordResetUrlNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Personal details.
        /// </summary>
        public static string PersonalDetails {
            get {
                return ResourceManager.GetString("PersonalDetails", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Your profile has been successfully edited.
        /// </summary>
        public static string ProfileEditSuccess {
            get {
                return ResourceManager.GetString("ProfileEditSuccess", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscription email.
        /// </summary>
        public static string SubscriptionEmail {
            get {
                return ResourceManager.GetString("SubscriptionEmail", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email not valid.
        /// </summary>
        public static string SubscriptionEmailNotValid {
            get {
                return ResourceManager.GetString("SubscriptionEmailNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Email and/or Password not valid.
        /// </summary>
        public static string SubscriptionEmailOrPasswordNotValid {
            get {
                return ResourceManager.GetString("SubscriptionEmailOrPasswordNotValid", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscriptions.
        /// </summary>
        public static string Subscriptions {
            get {
                return ResourceManager.GetString("Subscriptions", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Add subscription.
        /// </summary>
        public static string SubscriptionsAdd {
            get {
                return ResourceManager.GetString("SubscriptionsAdd", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Subscriptions configuration.
        /// </summary>
        public static string SubscriptionsConfiguration {
            get {
                return ResourceManager.GetString("SubscriptionsConfiguration", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Delete subscription.
        /// </summary>
        public static string SubscriptionsDelete {
            get {
                return ResourceManager.GetString("SubscriptionsDelete", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Edit subscription.
        /// </summary>
        public static string SubscriptionsEdit {
            get {
                return ResourceManager.GetString("SubscriptionsEdit", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Active.
        /// </summary>
        public static string SubscriptionStatusActive {
            get {
                return ResourceManager.GetString("SubscriptionStatusActive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Inactive.
        /// </summary>
        public static string SubscriptionStatusInactive {
            get {
                return ResourceManager.GetString("SubscriptionStatusInactive", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to Not verified.
        /// </summary>
        public static string SubscriptionStatusNotVerified {
            get {
                return ResourceManager.GetString("SubscriptionStatusNotVerified", resourceCulture);
            }
        }
        
        /// <summary>
        ///   Looks up a localized string similar to &lt;h2&gt;Thanks for registering!&lt;/h2&gt;
        ///&lt;p&gt;Please check your email and follow the link to confirm your identity and start using your account.&lt;/p&gt;.
        /// </summary>
        public static string Thanks {
            get {
                return ResourceManager.GetString("Thanks", resourceCulture);
            }
        }
    }
}
