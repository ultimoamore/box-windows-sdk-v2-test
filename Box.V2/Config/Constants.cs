﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Box.V2.Config
{
    public static class Constants
    {
        /*** Base API URIs ***/
        public const string BoxApiHostUriString = "https://www.box.com/api/";
        public const string BoxApiUriString = "https://api.box.com/2.0/";
        public const string BoxUploadApiUriString = "https://upload.box.com/api/2.0/";

        /*** API Endpoints ***/
        public const string AuthCodeString = @"oauth2/authorize";
        public const string AuthTokenEndpointString = @"oauth2/token";
        public const string RevokeEndpointString = @"oauth2/revoke";

        public const string FoldersString = @"folders/";
        public const string GroupsString = @"groups/";
        public const string GroupMembershipString = @"group_memberships/";
        public const string FilesString = @"files/";
        public const string FilesUploadString = @"files/content";
        public const string FilesNewVersionString = @"files/{0}/content";
        public const string CommentsString = @"comments/";
        public const string SearchString = @"search";
        public const string UserString = @"users/";
        public const string CollaborationsString = @"collaborations/";

        /*** API Full Endpoint Strings ***/
        public const string AuthCodeEndpointString = BoxApiHostUriString + AuthCodeString;
        public const string FoldersEndpointString = BoxApiUriString + FoldersString;
        public const string GroupsEndpointString = BoxApiUriString + GroupsString;
        public const string GroupMembershipEndpointString = BoxApiUriString + GroupMembershipString;
        public const string FilesEndpointString = BoxApiUriString + FilesString;
        public const string FilesUploadEndpointString = BoxUploadApiUriString + FilesUploadString;
        public const string FilesNewVersionEndpointString = BoxUploadApiUriString + FilesNewVersionString;
        public const string CommentsEndpointString = BoxApiUriString + CommentsString;
        public const string SearchEndpointString = BoxApiUriString + SearchString;
        public const string UserEndpointString = BoxApiUriString + UserString;
        public const string CollaborationsEndpointString = BoxApiUriString + CollaborationsString;


        /*** Endpoint Paths ***/
        public const string ItemsPathString = @"{0}/items";
        public const string VersionsPathString = @"{0}/versions";
        public const string CopyPathString = @"{0}/copy";
        public const string CommentsPathString = @"{0}/comments";
        public const string ThumbnailPathString = @"{0}/thumbnail.png";
        public const string PreviewPathString = @"{0}/preview.png";
        public const string TrashPathString = @"{0}/trash";
        public const string DiscussionsPathString = @"{0}/discussions";
        public const string CollaborationsPathString = @"{0}/collaborations";
        public const string TrashItemsPathString = @"trash/items";
        public const string TrashFolderPathString = @"{0}/trash";
        public const string GroupMembershipPathString = @"{0}/memberships";
        public const string ContentPathString = @"{0}/content";

        /*** Auth ***/
        public const string AuthHeaderKey = "Authorization";
        public const string V1AuthString = "BoxAuth api_key={0}&auth_token={1}";
        public const string V2AuthString = "Bearer {0}";

        /*** Return types ***/
        public const string TypeFile = "file";
        public const string TypeFolder = "folder";
        public const string TypeComment = "comment";
        public const string TypeWebLink = "web_link";
        public const string TypeCollaboration = "collaboration";
        public const string TypeFileVersion = "file_version";
        public const string TypeGroup = "group";
        public const string TypeGroupMembership = "group_membership";
        public const string TypeUser = "user";
        public const string TypeEnterprise = "enterprise";
        public const string TypeLock = "lock";

        /*** File Preview ***/
        public const int DefaultRetryDelay = 1000; // milliseconds

        public static class RequestParameters
        {
            /*** Keys ***/
            public const string GrantType = "grant_type";
            public const string Code = "code";
            public const string ClientId = "client_id";
            public const string ClientSecret = "client_secret";
            public const string Token = "token";
            public const string BoxDeviceId = "box_device_id";
            public const string BoxDeviceName = "box_device_name";

            public const string UserAgent = "User-Agent";
            public const string AcceptEncoding = "Accept-Encoding";

            /*** Values ***/
            public const string RefreshToken = "refresh_token";
            public const string AuthorizationCode = "authorization_code";
        }
    }
}
