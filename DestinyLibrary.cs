using System;
using System.Net.Http;
using System.Threading.Tasks;

namespace DestinyEndpints.ClassLibrary
{
    
    public class DestinyApi
    {
        private static HttpClient _Web = new HttpClient();
        const String BaseAddress = "https://www.bungie.net/Platform";

        public DestinyApi(string apiKey)
        {
            _Web.DefaultRequestHeaders.Add("X-API-Key", apiKey);
        }

        /// <summary>
        /// Loads a bungienet user by membership id.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> User_GetBungieNetUserByIdAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/User/GetBungieNetUserById/{id}/");
        }

        /// <summary>
        /// Loads a bungienet user by membership id.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String User_GetBungieNetUserById()
        {
            return User_GetBungieNetUserByIdAsync().Result;
        }

        /// <summary>
        /// Loads aliases of a bungienet membership id.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> User_GetUserAliasesAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/User/GetUserAliases/{id}/");
        }

        /// <summary>
        /// Loads aliases of a bungienet membership id.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String User_GetUserAliases()
        {
            return User_GetUserAliasesAsync().Result;
        }

        /// <summary>
        /// Returns a list of possible users based on the search string
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> User_SearchUsersAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/User/SearchUsers/");
        }

        /// <summary>
        /// Returns a list of possible users based on the search string
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String User_SearchUsers()
        {
            return User_SearchUsersAsync().Result;
        }

        /// <summary>
        /// Returns a list of all available user themes.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> User_GetAvailableThemesAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/User/GetAvailableThemes/");
        }

        /// <summary>
        /// Returns a list of all available user themes.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String User_GetAvailableThemes()
        {
            return User_GetAvailableThemesAsync().Result;
        }

        /// <summary>
        /// Returns a list of accounts associated with the supplied membership ID and membership type. This will include all linked accounts (even when hidden) if supplied credentials permit it.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> User_GetMembershipDataByIdAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/User/GetMembershipsById/{membershipId}/{membershipType}/");
        }

        /// <summary>
        /// Returns a list of accounts associated with the supplied membership ID and membership type. This will include all linked accounts (even when hidden) if supplied credentials permit it.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String User_GetMembershipDataById()
        {
            return User_GetMembershipDataByIdAsync().Result;
        }

        /// <summary>
        /// Returns a list of accounts associated with signed in user. This is useful for OAuth implementations that do not give you access to the token response.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> User_GetMembershipDataForCurrentUserAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/User/GetMembershipsForCurrentUser/");
        }

        /// <summary>
        /// Returns a list of accounts associated with signed in user. This is useful for OAuth implementations that do not give you access to the token response.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String User_GetMembershipDataForCurrentUser()
        {
            return User_GetMembershipDataForCurrentUserAsync().Result;
        }

        /// <summary>
        /// Returns a user's linked Partnerships.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> User_GetPartnershipsAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/User/{membershipId}/Partnerships/");
        }

        /// <summary>
        /// Returns a user's linked Partnerships.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String User_GetPartnerships()
        {
            return User_GetPartnershipsAsync().Result;
        }

        /// <summary>
        /// Get topics from any forum.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Forum_GetTopicsPagedAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Forum/GetTopicsPaged/{page}/{pageSize}/{group}/{sort}/{quickDate}/{categoryFilter}/");
        }

        /// <summary>
        /// Get topics from any forum.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Forum_GetTopicsPaged()
        {
            return Forum_GetTopicsPagedAsync().Result;
        }

        /// <summary>
        /// Gets a listing of all topics marked as part of the core group.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Forum_GetCoreTopicsPagedAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Forum/GetCoreTopicsPaged/{page}/{sort}/{quickDate}/{categoryFilter}/");
        }

        /// <summary>
        /// Gets a listing of all topics marked as part of the core group.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Forum_GetCoreTopicsPaged()
        {
            return Forum_GetCoreTopicsPagedAsync().Result;
        }

        /// <summary>
        /// Returns a thread of posts at the given parent, optionally returning replies to those posts as well as the original parent.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Forum_GetPostsThreadedPagedAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Forum/GetPostsThreadedPaged/{parentPostId}/{page}/{pageSize}/{replySize}/{getParentPost}/{rootThreadMode}/{sortMode}/");
        }

        /// <summary>
        /// Returns a thread of posts at the given parent, optionally returning replies to those posts as well as the original parent.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Forum_GetPostsThreadedPaged()
        {
            return Forum_GetPostsThreadedPagedAsync().Result;
        }

        /// <summary>
        /// Returns a thread of posts starting at the topicId of the input childPostId, optionally returning replies to those posts as well as the original parent.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Forum_GetPostsThreadedPagedFromChildAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Forum/GetPostsThreadedPagedFromChild/{childPostId}/{page}/{pageSize}/{replySize}/{rootThreadMode}/{sortMode}/");
        }

        /// <summary>
        /// Returns a thread of posts starting at the topicId of the input childPostId, optionally returning replies to those posts as well as the original parent.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Forum_GetPostsThreadedPagedFromChild()
        {
            return Forum_GetPostsThreadedPagedFromChildAsync().Result;
        }

        /// <summary>
        /// Returns the post specified and its immediate parent.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Forum_GetPostAndParentAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Forum/GetPostAndParent/{childPostId}/");
        }

        /// <summary>
        /// Returns the post specified and its immediate parent.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Forum_GetPostAndParent()
        {
            return Forum_GetPostAndParentAsync().Result;
        }

        /// <summary>
        /// Returns the post specified and its immediate parent of posts that are awaiting approval.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Forum_GetPostAndParentAwaitingApprovalAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Forum/GetPostAndParentAwaitingApproval/{childPostId}/");
        }

        /// <summary>
        /// Returns the post specified and its immediate parent of posts that are awaiting approval.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Forum_GetPostAndParentAwaitingApproval()
        {
            return Forum_GetPostAndParentAwaitingApprovalAsync().Result;
        }

        /// <summary>
        /// Gets the post Id for the given content item's comments, if it exists.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Forum_GetTopicForContentAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Forum/GetTopicForContent/{contentId}/");
        }

        /// <summary>
        /// Gets the post Id for the given content item's comments, if it exists.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Forum_GetTopicForContent()
        {
            return Forum_GetTopicForContentAsync().Result;
        }

        /// <summary>
        /// Gets tag suggestions based on partial text entry, matching them with other tags previously used in the forums.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Forum_GetForumTagSuggestionsAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Forum/GetForumTagSuggestions/");
        }

        /// <summary>
        /// Gets tag suggestions based on partial text entry, matching them with other tags previously used in the forums.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Forum_GetForumTagSuggestions()
        {
            return Forum_GetForumTagSuggestionsAsync().Result;
        }

        /// <summary>
        /// Gets the specified forum poll.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Forum_GetPollAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Forum/Poll/{topicId}/");
        }

        /// <summary>
        /// Gets the specified forum poll.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Forum_GetPoll()
        {
            return Forum_GetPollAsync().Result;
        }

        /// <summary>
        /// Returns the current version of the manifest as a json object.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetDestinyManifestAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/Manifest/");
        }

        /// <summary>
        /// Returns the current version of the manifest as a json object.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetDestinyManifest()
        {
            return Destiny2_GetDestinyManifestAsync().Result;
        }

        /// <summary>
        /// Returns a list of Destiny memberships given a full Gamertag or PSN ID.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_SearchDestinyPlayerAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/SearchDestinyPlayer/{membershipType}/{displayName}/");
        }

        /// <summary>
        /// Returns a list of Destiny memberships given a full Gamertag or PSN ID.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_SearchDestinyPlayer()
        {
            return Destiny2_SearchDestinyPlayerAsync().Result;
        }

        /// <summary>
        /// Returns Destiny Profile information for the supplied membership.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetProfileAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/{membershipType}/Profile/{destinyMembershipId}/");
        }

        /// <summary>
        /// Returns Destiny Profile information for the supplied membership.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetProfile()
        {
            return Destiny2_GetProfileAsync().Result;
        }

        /// <summary>
        /// Returns character information for the supplied character.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetCharacterAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/");
        }

        /// <summary>
        /// Returns character information for the supplied character.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetCharacter()
        {
            return Destiny2_GetCharacterAsync().Result;
        }

        /// <summary>
        /// Returns information on the weekly clan rewards and if the clan has earned them or not. Note that this will always report rewards as not redeemed.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetClanWeeklyRewardStateAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/Clan/{groupId}/WeeklyRewardState/");
        }

        /// <summary>
        /// Returns information on the weekly clan rewards and if the clan has earned them or not. Note that this will always report rewards as not redeemed.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetClanWeeklyRewardState()
        {
            return Destiny2_GetClanWeeklyRewardStateAsync().Result;
        }

        /// <summary>
        /// Retrieve the details of an instanced Destiny Item.  An instanced Destiny item is one with an ItemInstanceId.  Non-instanced items, such as materials, have no useful instance-specific details and thus are not queryable here.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetItemAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Item/{itemInstanceId}/");
        }

        /// <summary>
        /// Retrieve the details of an instanced Destiny Item.  An instanced Destiny item is one with an ItemInstanceId.  Non-instanced items, such as materials, have no useful instance-specific details and thus are not queryable here.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetItem()
        {
            return Destiny2_GetItemAsync().Result;
        }

        /// <summary>
        /// Get currently available vendors.  PREVIEW: This service is not yet active, but we are returning the planned schema of the endpoint for review, comment, and preparation for its eventual implementation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetVendorsAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Vendors/");
        }

        /// <summary>
        /// Get currently available vendors.  PREVIEW: This service is not yet active, but we are returning the planned schema of the endpoint for review, comment, and preparation for its eventual implementation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetVendors()
        {
            return Destiny2_GetVendorsAsync().Result;
        }

        /// <summary>
        /// Get the details of a specific Vendor.  PREVIEW: This service is not yet active, but we are returning the planned schema of the endpoint for review, comment, and preparation for its eventual implementation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetVendorAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/{membershipType}/Profile/{destinyMembershipId}/Character/{characterId}/Vendors/{vendorHash}/");
        }

        /// <summary>
        /// Get the details of a specific Vendor.  PREVIEW: This service is not yet active, but we are returning the planned schema of the endpoint for review, comment, and preparation for its eventual implementation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetVendor()
        {
            return Destiny2_GetVendorAsync().Result;
        }

        /// <summary>
        /// Gets the available post game carnage report for the activity ID.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetPostGameCarnageReportAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/Stats/PostGameCarnageReport/{activityId}/");
        }

        /// <summary>
        /// Gets the available post game carnage report for the activity ID.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetPostGameCarnageReport()
        {
            return Destiny2_GetPostGameCarnageReportAsync().Result;
        }

        /// <summary>
        /// Gets historical stats definitions.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetHistoricalStatsDefinitionAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/Stats/Definition/");
        }

        /// <summary>
        /// Gets historical stats definitions.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetHistoricalStatsDefinition()
        {
            return Destiny2_GetHistoricalStatsDefinitionAsync().Result;
        }

        /// <summary>
        /// Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetClanLeaderboardsAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/Stats/Leaderboards/Clans/{groupId}/");
        }

        /// <summary>
        /// Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetClanLeaderboards()
        {
            return Destiny2_GetClanLeaderboardsAsync().Result;
        }

        /// <summary>
        /// Gets aggregated stats for a clan using the same categories as the clan leaderboards.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetClanAggregateStatsAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/Stats/AggregateClanStats/{groupId}/");
        }

        /// <summary>
        /// Gets aggregated stats for a clan using the same categories as the clan leaderboards.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetClanAggregateStats()
        {
            return Destiny2_GetClanAggregateStatsAsync().Result;
        }

        /// <summary>
        /// Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus.  PREVIEW: This endpoint has not yet been implemented.  It is being returned for a preview of future functionality, and for public comment/suggestion/preparation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetLeaderboardsAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/Leaderboards/");
        }

        /// <summary>
        /// Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus.  PREVIEW: This endpoint has not yet been implemented.  It is being returned for a preview of future functionality, and for public comment/suggestion/preparation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetLeaderboards()
        {
            return Destiny2_GetLeaderboardsAsync().Result;
        }

        /// <summary>
        /// Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetLeaderboardsForCharacterAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/Stats/Leaderboards/{membershipType}/{destinyMembershipId}/{characterId}/");
        }

        /// <summary>
        /// Gets leaderboards with the signed in user's friends and the supplied destinyMembershipId as the focus.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetLeaderboardsForCharacter()
        {
            return Destiny2_GetLeaderboardsForCharacterAsync().Result;
        }

        /// <summary>
        /// Gets a page list of Destiny items.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_SearchDestinyEntitiesAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/Armory/Search/{type}/{searchTerm}/");
        }

        /// <summary>
        /// Gets a page list of Destiny items.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_SearchDestinyEntities()
        {
            return Destiny2_SearchDestinyEntitiesAsync().Result;
        }

        /// <summary>
        /// Gets historical stats for indicated character.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetHistoricalStatsAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/");
        }

        /// <summary>
        /// Gets historical stats for indicated character.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetHistoricalStats()
        {
            return Destiny2_GetHistoricalStatsAsync().Result;
        }

        /// <summary>
        /// Gets aggregate historical stats organized around each character for a given account.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetHistoricalStatsForAccountAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/{membershipType}/Account/{destinyMembershipId}/Stats/");
        }

        /// <summary>
        /// Gets aggregate historical stats organized around each character for a given account.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetHistoricalStatsForAccount()
        {
            return Destiny2_GetHistoricalStatsForAccountAsync().Result;
        }

        /// <summary>
        /// Gets activity history stats for indicated character.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetActivityHistoryAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/Activities/");
        }

        /// <summary>
        /// Gets activity history stats for indicated character.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetActivityHistory()
        {
            return Destiny2_GetActivityHistoryAsync().Result;
        }

        /// <summary>
        /// Gets details about unique weapon usage, including all exotic weapons.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetUniqueWeaponHistoryAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/UniqueWeapons/");
        }

        /// <summary>
        /// Gets details about unique weapon usage, including all exotic weapons.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetUniqueWeaponHistory()
        {
            return Destiny2_GetUniqueWeaponHistoryAsync().Result;
        }

        /// <summary>
        /// Gets all activities the character has participated in together with aggregate statistics for those activities.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetDestinyAggregateActivityStatsAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/{membershipType}/Account/{destinyMembershipId}/Character/{characterId}/Stats/AggregateActivityStats/");
        }

        /// <summary>
        /// Gets all activities the character has participated in together with aggregate statistics for those activities.  PREVIEW: This endpoint is still in beta, and may experience rough edges.  The schema is in final form, but there may be bugs that prevent desirable operation.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetDestinyAggregateActivityStats()
        {
            return Destiny2_GetDestinyAggregateActivityStatsAsync().Result;
        }

        /// <summary>
        /// Gets custom localized content for the milestone of the given hash, if it exists.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetPublicMilestoneContentAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/Milestones/{milestoneHash}/Content/");
        }

        /// <summary>
        /// Gets custom localized content for the milestone of the given hash, if it exists.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetPublicMilestoneContent()
        {
            return Destiny2_GetPublicMilestoneContentAsync().Result;
        }

        /// <summary>
        /// Gets public information about currently available Milestones.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Destiny2_GetPublicMilestonesAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Destiny2/Milestones/");
        }

        /// <summary>
        /// Gets public information about currently available Milestones.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Destiny2_GetPublicMilestones()
        {
            return Destiny2_GetPublicMilestonesAsync().Result;
        }

        /// <summary>
        /// Returns community content.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> CommunityContent_GetCommunityContentAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/CommunityContent/Get/{sort}/{mediaFilter}/{page}/");
        }

        /// <summary>
        /// Returns community content.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String CommunityContent_GetCommunityContent()
        {
            return CommunityContent_GetCommunityContentAsync().Result;
        }

        /// <summary>
        /// Returns info about community members who are live streaming.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> CommunityContent_GetCommunityLiveStatusesAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/CommunityContent/Live/All/{partnershipType}/{sort}/{page}/");
        }

        /// <summary>
        /// Returns info about community members who are live streaming.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String CommunityContent_GetCommunityLiveStatuses()
        {
            return CommunityContent_GetCommunityLiveStatusesAsync().Result;
        }

        /// <summary>
        /// Returns info about community members who are live streaming in your clans.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> CommunityContent_GetCommunityLiveStatusesForClanmatesAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/CommunityContent/Live/Clan/{partnershipType}/{sort}/{page}/");
        }

        /// <summary>
        /// Returns info about community members who are live streaming in your clans.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String CommunityContent_GetCommunityLiveStatusesForClanmates()
        {
            return CommunityContent_GetCommunityLiveStatusesForClanmatesAsync().Result;
        }

        /// <summary>
        /// Returns info about community members who are live streaming among your friends.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> CommunityContent_GetCommunityLiveStatusesForFriendsAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/CommunityContent/Live/Friends/{partnershipType}/{sort}/{page}/");
        }

        /// <summary>
        /// Returns info about community members who are live streaming among your friends.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String CommunityContent_GetCommunityLiveStatusesForFriends()
        {
            return CommunityContent_GetCommunityLiveStatusesForFriendsAsync().Result;
        }

        /// <summary>
        /// Returns info about Featured live streams.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> CommunityContent_GetFeaturedCommunityLiveStatusesAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/CommunityContent/Live/Featured/{partnershipType}/{sort}/{page}/");
        }

        /// <summary>
        /// Returns info about Featured live streams.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String CommunityContent_GetFeaturedCommunityLiveStatuses()
        {
            return CommunityContent_GetFeaturedCommunityLiveStatusesAsync().Result;
        }

        /// <summary>
        /// Gets the Live Streaming status of a particular Account and Membership Type.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> CommunityContent_GetStreamingStatusForMemberAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/CommunityContent/Live/Users/{partnershipType}/{membershipType}/{membershipId}/");
        }

        /// <summary>
        /// Gets the Live Streaming status of a particular Account and Membership Type.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String CommunityContent_GetStreamingStatusForMember()
        {
            return CommunityContent_GetStreamingStatusForMemberAsync().Result;
        }

        /// <summary>
        /// Returns trending items for Bungie.net, collapsed into the first page of items per category.  For pagination within a category, call GetTrendingCategory.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Trending_GetTrendingCategoriesAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Trending/Categories/");
        }

        /// <summary>
        /// Returns trending items for Bungie.net, collapsed into the first page of items per category.  For pagination within a category, call GetTrendingCategory.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Trending_GetTrendingCategories()
        {
            return Trending_GetTrendingCategoriesAsync().Result;
        }

        /// <summary>
        /// Returns paginated lists of trending items for a category.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Trending_GetTrendingCategoryAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Trending/Categories/{categoryId}/{pageNumber}/");
        }

        /// <summary>
        /// Returns paginated lists of trending items for a category.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Trending_GetTrendingCategory()
        {
            return Trending_GetTrendingCategoryAsync().Result;
        }

        /// <summary>
        /// Returns the detailed results for a specific trending entry.  Note that trending entries are uniquely identified by a combination of *both* the TrendingEntryType *and* the identifier: the identifier alone is not guaranteed to be globally unique.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public async Task<String> Trending_GetTrendingEntryDetailAsync()
        {
            return await _Web.GetStringAsync(BaseAddress + "/Trending/Details/{trendingEntryType}/{identifier}/");
        }

        /// <summary>
        /// Returns the detailed results for a specific trending entry.  Note that trending entries are uniquely identified by a combination of *both* the TrendingEntryType *and* the identifier: the identifier alone is not guaranteed to be globally unique.
        /// </summary>
        /// <returns>A json string for this endpoint</returns>
        public String Trending_GetTrendingEntryDetail()
        {
            return Trending_GetTrendingEntryDetailAsync().Result;
        }

    }
}
                    