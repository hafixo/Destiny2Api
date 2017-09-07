using System;
using System.Collections.Generic;
using System.Text;
using Newtonsoft.Json;

namespace DestinyEndpointGenerator.EndpointGenerator.Models
{
    public class OpenApi2Model
    {
        public string swagger { get; set; }
        public Info info { get; set; }
        public string host { get; set; }
        public string basePath { get; set; }
        public string[] schemes { get; set; }
        public Paths paths { get; set; }
        public Definitions definitions { get; set; }
        public Securitydefinitions securityDefinitions { get; set; }
        public Tag[] tags { get; set; }
        public Externaldocs externalDocs { get; set; }
    }
    

    public class Info
    {
        public string title { get; set; }
        public string description { get; set; }
        public string termsOfService { get; set; }
        public Contact contact { get; set; }
        public License license { get; set; }
        public string version { get; set; }
    }

    public class Contact
    {
        public string name { get; set; }
        public string url { get; set; }
        public string email { get; set; }
    }

    public class License
    {
        public string name { get; set; }
        public string url { get; set; }
    }

    public class Paths
    {
        [JsonProperty(PropertyName = "/User/GetBungieNetUserById/{id}/")]
        public UserGetbungienetuserbyidId UserGetBungieNetUserByIdid { get; set; }
        public UserGetuseraliasesId UserGetUserAliasesid { get; set; }
        public UserSearchusers UserSearchUsers { get; set; }
        public UserGetavailablethemes UserGetAvailableThemes { get; set; }
        public UserGetmembershipsbyidMembershipidMembershiptype UserGetMembershipsByIdmembershipIdmembershipType { get; set; }
        public UserGetmembershipsforcurrentuser UserGetMembershipsForCurrentUser { get; set; }
        public UserMembershipidPartnerships UsermembershipIdPartnerships { get; set; }
        public ForumGettopicspagedPagePagesizeGroupSortQuickdateCategoryfilter ForumGetTopicsPagedpagepageSizegroupsortquickDatecategoryFilter { get; set; }
        public ForumGetcoretopicspagedPageSortQuickdateCategoryfilter ForumGetCoreTopicsPagedpagesortquickDatecategoryFilter { get; set; }
        public ForumGetpoststhreadedpagedParentpostidPagePagesizeReplysizeGetparentpostRootthreadmodeSortmode ForumGetPostsThreadedPagedparentPostIdpagepageSizereplySizegetParentPostrootThreadModesortMode { get; set; }
        public ForumGetpoststhreadedpagedfromchildChildpostidPagePagesizeReplysizeRootthreadmodeSortmode ForumGetPostsThreadedPagedFromChildchildPostIdpagepageSizereplySizerootThreadModesortMode { get; set; }
        public ForumGetpostandparentChildpostid ForumGetPostAndParentchildPostId { get; set; }
        public ForumGetpostandparentawaitingapprovalChildpostid ForumGetPostAndParentAwaitingApprovalchildPostId { get; set; }
        public ForumGettopicforcontentContentid ForumGetTopicForContentcontentId { get; set; }
        public ForumGetforumtagsuggestions ForumGetForumTagSuggestions { get; set; }
        public ForumPollTopicid ForumPolltopicId { get; set; }
        public ForumRecruitJoinTopicid ForumRecruitJointopicId { get; set; }
        public ForumRecruitLeaveTopicid ForumRecruitLeavetopicId { get; set; }
        public ForumRecruitKickbanTopicidTargetmembershipid ForumRecruitKickBantopicIdtargetMembershipId { get; set; }
        public ForumRecruitApproveTopicid ForumRecruitApprovetopicId { get; set; }
        public ForumRecruitSummaries ForumRecruitSummaries { get; set; }
        public Destiny2Manifest Destiny2Manifest { get; set; }
        public Destiny2SearchdestinyplayerMembershiptypeDisplayname Destiny2SearchDestinyPlayermembershipTypedisplayName { get; set; }
        public Destiny2MembershiptypeProfileDestinymembershipid Destiny2membershipTypeProfiledestinyMembershipId { get; set; }
        public Destiny2MembershiptypeProfileDestinymembershipidCharacterCharacterid Destiny2membershipTypeProfiledestinyMembershipIdCharactercharacterId { get; set; }
        public Destiny2ClanGroupidWeeklyrewardstate Destiny2ClangroupIdWeeklyRewardState { get; set; }
        public Destiny2MembershiptypeProfileDestinymembershipidItemIteminstanceid Destiny2membershipTypeProfiledestinyMembershipIdItemitemInstanceId { get; set; }
        public Destiny2MembershiptypeProfileDestinymembershipidCharacterCharacteridVendors Destiny2membershipTypeProfiledestinyMembershipIdCharactercharacterIdVendors { get; set; }
        public Destiny2MembershiptypeProfileDestinymembershipidCharacterCharacteridVendorsVendorhash Destiny2membershipTypeProfiledestinyMembershipIdCharactercharacterIdVendorsvendorHash { get; set; }
        public Destiny2ActionsItemsTransferitem Destiny2ActionsItemsTransferItem { get; set; }
        public Destiny2ActionsItemsEquipitem Destiny2ActionsItemsEquipItem { get; set; }
        public Destiny2ActionsItemsEquipitems Destiny2ActionsItemsEquipItems { get; set; }
        public Destiny2ActionsItemsSetlockstate Destiny2ActionsItemsSetLockState { get; set; }
        public Destiny2ActionsItemsInsertsocketplug Destiny2ActionsItemsInsertSocketPlug { get; set; }
        public Destiny2ActionsItemsActivatetalentnode Destiny2ActionsItemsActivateTalentNode { get; set; }
        public Destiny2StatsPostgamecarnagereportActivityid Destiny2StatsPostGameCarnageReportactivityId { get; set; }
        public Destiny2StatsDefinition Destiny2StatsDefinition { get; set; }
        public Destiny2StatsLeaderboardsClansGroupid Destiny2StatsLeaderboardsClansgroupId { get; set; }
        public Destiny2StatsAggregateclanstatsGroupid Destiny2StatsAggregateClanStatsgroupId { get; set; }
        public Destiny2MembershiptypeAccountDestinymembershipidStatsLeaderboards Destiny2membershipTypeAccountdestinyMembershipIdStatsLeaderboards { get; set; }
        public Destiny2StatsLeaderboardsMembershiptypeDestinymembershipidCharacterid Destiny2StatsLeaderboardsmembershipTypedestinyMembershipIdcharacterId { get; set; }
        public Destiny2ArmorySearchTypeSearchterm Destiny2ArmorySearchtypesearchTerm { get; set; }
        public Destiny2MembershiptypeAccountDestinymembershipidCharacterCharacteridStats Destiny2membershipTypeAccountdestinyMembershipIdCharactercharacterIdStats { get; set; }
        public Destiny2MembershiptypeAccountDestinymembershipidStats Destiny2membershipTypeAccountdestinyMembershipIdStats { get; set; }
        public Destiny2MembershiptypeAccountDestinymembershipidCharacterCharacteridStatsActivities Destiny2membershipTypeAccountdestinyMembershipIdCharactercharacterIdStatsActivities { get; set; }
        public Destiny2MembershiptypeAccountDestinymembershipidCharacterCharacteridStatsUniqueweapons Destiny2membershipTypeAccountdestinyMembershipIdCharactercharacterIdStatsUniqueWeapons { get; set; }
        public Destiny2MembershiptypeAccountDestinymembershipidCharacterCharacteridStatsAggregateactivitystats Destiny2membershipTypeAccountdestinyMembershipIdCharactercharacterIdStatsAggregateActivityStats { get; set; }
        public Destiny2MilestonesMilestonehashContent Destiny2MilestonesmilestoneHashContent { get; set; }
        public Destiny2Milestones Destiny2Milestones { get; set; }
        public CommunitycontentGetSortMediafilterPage CommunityContentGetsortmediaFilterpage { get; set; }
        public CommunitycontentLiveAllPartnershiptypeSortPage CommunityContentLiveAllpartnershipTypesortpage { get; set; }
        public CommunitycontentLiveClanPartnershiptypeSortPage CommunityContentLiveClanpartnershipTypesortpage { get; set; }
        public CommunitycontentLiveFriendsPartnershiptypeSortPage CommunityContentLiveFriendspartnershipTypesortpage { get; set; }
        public CommunitycontentLiveFeaturedPartnershiptypeSortPage CommunityContentLiveFeaturedpartnershipTypesortpage { get; set; }
        public CommunitycontentLiveUsersPartnershiptypeMembershiptypeMembershipid CommunityContentLiveUserspartnershipTypemembershipTypemembershipId { get; set; }
        public TrendingCategories TrendingCategories { get; set; }
        public TrendingCategoriesCategoryidPagenumber TrendingCategoriescategoryIdpageNumber { get; set; }
        public TrendingDetailsTrendingentrytypeIdentifier TrendingDetailstrendingEntryTypeidentifier { get; set; }
    }

    public class UserGetbungienetuserbyidId
    {
        public Get get { get; set; }
    }

    public class Get
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter[] parameters { get; set; }
        public Responses responses { get; set; }
    }

    public class Responses
    {
        public _200 _200 { get; set; }
    }

    public class _200
    {
        public string description { get; set; }
        public Schema schema { get; set; }
    }

    public class Schema
    {
        public Properties properties { get; set; }
    }

    public class Properties
    {
        public Response Response { get; set; }
        public Errorcode ErrorCode { get; set; }
        public Throttleseconds ThrottleSeconds { get; set; }
        public Errorstatus ErrorStatus { get; set; }
        public Message Message { get; set; }
        public Messagedata MessageData { get; set; }
    }

    public class Response
    {
        public string _ref { get; set; }
    }

    public class Errorcode
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus
    {
        public string type { get; set; }
    }

    public class Message
    {
        public string type { get; set; }
    }

    public class Messagedata
    {
        public string type { get; set; }
        public Additionalproperties additionalProperties { get; set; }
    }

    public class Additionalproperties
    {
        public string type { get; set; }
    }

    public class Parameter
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class UserGetuseraliasesId
    {
        public Get1 get { get; set; }
    }

    public class Get1
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter1[] parameters { get; set; }
        public Responses1 responses { get; set; }
    }

    public class Responses1
    {
        public _2001 _200 { get; set; }
    }

    public class _2001
    {
        public string description { get; set; }
        public Schema1 schema { get; set; }
    }

    public class Schema1
    {
        public Properties1 properties { get; set; }
    }

    public class Properties1
    {
        public Response1 Response { get; set; }
        public Errorcode1 ErrorCode { get; set; }
        public Throttleseconds1 ThrottleSeconds { get; set; }
        public Errorstatus1 ErrorStatus { get; set; }
        public Message1 Message { get; set; }
        public Messagedata1 MessageData { get; set; }
    }

    public class Response1
    {
        public string type { get; set; }
        public Items items { get; set; }
    }

    public class Items
    {
        public string _ref { get; set; }
    }

    public class Errorcode1
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus1
    {
        public string type { get; set; }
    }

    public class Message1
    {
        public string type { get; set; }
    }

    public class Messagedata1
    {
        public string type { get; set; }
        public Additionalproperties1 additionalProperties { get; set; }
    }

    public class Additionalproperties1
    {
        public string type { get; set; }
    }

    public class Parameter1
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class UserSearchusers
    {
        public Get2 get { get; set; }
    }

    public class Get2
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter2[] parameters { get; set; }
        public Responses2 responses { get; set; }
    }

    public class Responses2
    {
        public _2002 _200 { get; set; }
    }

    public class _2002
    {
        public string description { get; set; }
        public Schema2 schema { get; set; }
    }

    public class Schema2
    {
        public Properties2 properties { get; set; }
    }

    public class Properties2
    {
        public Response2 Response { get; set; }
        public Errorcode2 ErrorCode { get; set; }
        public Throttleseconds2 ThrottleSeconds { get; set; }
        public Errorstatus2 ErrorStatus { get; set; }
        public Message2 Message { get; set; }
        public Messagedata2 MessageData { get; set; }
    }

    public class Response2
    {
        public string type { get; set; }
        public Items1 items { get; set; }
    }

    public class Items1
    {
        public string _ref { get; set; }
    }

    public class Errorcode2
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds2
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus2
    {
        public string type { get; set; }
    }

    public class Message2
    {
        public string type { get; set; }
    }

    public class Messagedata2
    {
        public string type { get; set; }
        public Additionalproperties2 additionalProperties { get; set; }
    }

    public class Additionalproperties2
    {
        public string type { get; set; }
    }

    public class Parameter2
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class UserGetavailablethemes
    {
        public Get3 get { get; set; }
    }

    public class Get3
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public object[] parameters { get; set; }
        public Responses3 responses { get; set; }
    }

    public class Responses3
    {
        public _2003 _200 { get; set; }
    }

    public class _2003
    {
        public string description { get; set; }
        public Schema3 schema { get; set; }
    }

    public class Schema3
    {
        public Properties3 properties { get; set; }
    }

    public class Properties3
    {
        public Response3 Response { get; set; }
        public Errorcode3 ErrorCode { get; set; }
        public Throttleseconds3 ThrottleSeconds { get; set; }
        public Errorstatus3 ErrorStatus { get; set; }
        public Message3 Message { get; set; }
        public Messagedata3 MessageData { get; set; }
    }

    public class Response3
    {
        public string type { get; set; }
        public Items2 items { get; set; }
    }

    public class Items2
    {
        public string _ref { get; set; }
    }

    public class Errorcode3
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds3
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus3
    {
        public string type { get; set; }
    }

    public class Message3
    {
        public string type { get; set; }
    }

    public class Messagedata3
    {
        public string type { get; set; }
        public Additionalproperties3 additionalProperties { get; set; }
    }

    public class Additionalproperties3
    {
        public string type { get; set; }
    }

    public class UserGetmembershipsbyidMembershipidMembershiptype
    {
        public Get4 get { get; set; }
    }

    public class Get4
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter3[] parameters { get; set; }
        public Responses4 responses { get; set; }
    }

    public class Responses4
    {
        public _2004 _200 { get; set; }
    }

    public class _2004
    {
        public string description { get; set; }
        public Schema4 schema { get; set; }
    }

    public class Schema4
    {
        public Properties4 properties { get; set; }
    }

    public class Properties4
    {
        public Response4 Response { get; set; }
        public Errorcode4 ErrorCode { get; set; }
        public Throttleseconds4 ThrottleSeconds { get; set; }
        public Errorstatus4 ErrorStatus { get; set; }
        public Message4 Message { get; set; }
        public Messagedata4 MessageData { get; set; }
    }

    public class Response4
    {
        public string _ref { get; set; }
    }

    public class Errorcode4
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds4
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus4
    {
        public string type { get; set; }
    }

    public class Message4
    {
        public string type { get; set; }
    }

    public class Messagedata4
    {
        public string type { get; set; }
        public Additionalproperties4 additionalProperties { get; set; }
    }

    public class Additionalproperties4
    {
        public string type { get; set; }
    }

    public class Parameter3
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class UserGetmembershipsforcurrentuser
    {
        public Get5 get { get; set; }
    }

    public class Get5
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public object[] parameters { get; set; }
        public Security[] security { get; set; }
        public Responses5 responses { get; set; }
    }

    public class Responses5
    {
        public _2005 _200 { get; set; }
    }

    public class _2005
    {
        public string description { get; set; }
        public Schema5 schema { get; set; }
    }

    public class Schema5
    {
        public Properties5 properties { get; set; }
    }

    public class Properties5
    {
        public Response5 Response { get; set; }
        public Errorcode5 ErrorCode { get; set; }
        public Throttleseconds5 ThrottleSeconds { get; set; }
        public Errorstatus5 ErrorStatus { get; set; }
        public Message5 Message { get; set; }
        public Messagedata5 MessageData { get; set; }
    }

    public class Response5
    {
        public string _ref { get; set; }
    }

    public class Errorcode5
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds5
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus5
    {
        public string type { get; set; }
    }

    public class Message5
    {
        public string type { get; set; }
    }

    public class Messagedata5
    {
        public string type { get; set; }
        public Additionalproperties5 additionalProperties { get; set; }
    }

    public class Additionalproperties5
    {
        public string type { get; set; }
    }

    public class Security
    {
        public string[] oauth2 { get; set; }
    }

    public class UserMembershipidPartnerships
    {
        public Get6 get { get; set; }
    }

    public class Get6
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter4[] parameters { get; set; }
        public Responses6 responses { get; set; }
    }

    public class Responses6
    {
        public _2006 _200 { get; set; }
    }

    public class _2006
    {
        public string description { get; set; }
        public Schema6 schema { get; set; }
    }

    public class Schema6
    {
        public Properties6 properties { get; set; }
    }

    public class Properties6
    {
        public Response6 Response { get; set; }
        public Errorcode6 ErrorCode { get; set; }
        public Throttleseconds6 ThrottleSeconds { get; set; }
        public Errorstatus6 ErrorStatus { get; set; }
        public Message6 Message { get; set; }
        public Messagedata6 MessageData { get; set; }
    }

    public class Response6
    {
        public string type { get; set; }
        public Items3 items { get; set; }
    }

    public class Items3
    {
        public string _ref { get; set; }
    }

    public class Errorcode6
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds6
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus6
    {
        public string type { get; set; }
    }

    public class Message6
    {
        public string type { get; set; }
    }

    public class Messagedata6
    {
        public string type { get; set; }
        public Additionalproperties6 additionalProperties { get; set; }
    }

    public class Additionalproperties6
    {
        public string type { get; set; }
    }

    public class Parameter4
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ForumGettopicspagedPagePagesizeGroupSortQuickdateCategoryfilter
    {
        public Get7 get { get; set; }
    }

    public class Get7
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter5[] parameters { get; set; }
        public Responses7 responses { get; set; }
    }

    public class Responses7
    {
        public _2007 _200 { get; set; }
    }

    public class _2007
    {
        public string description { get; set; }
        public Schema7 schema { get; set; }
    }

    public class Schema7
    {
        public Properties7 properties { get; set; }
    }

    public class Properties7
    {
        public Response7 Response { get; set; }
        public Errorcode7 ErrorCode { get; set; }
        public Throttleseconds7 ThrottleSeconds { get; set; }
        public Errorstatus7 ErrorStatus { get; set; }
        public Message7 Message { get; set; }
        public Messagedata7 MessageData { get; set; }
    }

    public class Response7
    {
        public string _ref { get; set; }
    }

    public class Errorcode7
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds7
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus7
    {
        public string type { get; set; }
    }

    public class Message7
    {
        public string type { get; set; }
    }

    public class Messagedata7
    {
        public string type { get; set; }
        public Additionalproperties7 additionalProperties { get; set; }
    }

    public class Additionalproperties7
    {
        public string type { get; set; }
    }

    public class Parameter5
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class ForumGetcoretopicspagedPageSortQuickdateCategoryfilter
    {
        public Get8 get { get; set; }
    }

    public class Get8
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter6[] parameters { get; set; }
        public Responses8 responses { get; set; }
    }

    public class Responses8
    {
        public _2008 _200 { get; set; }
    }

    public class _2008
    {
        public string description { get; set; }
        public Schema8 schema { get; set; }
    }

    public class Schema8
    {
        public Properties8 properties { get; set; }
    }

    public class Properties8
    {
        public Response8 Response { get; set; }
        public Errorcode8 ErrorCode { get; set; }
        public Throttleseconds8 ThrottleSeconds { get; set; }
        public Errorstatus8 ErrorStatus { get; set; }
        public Message8 Message { get; set; }
        public Messagedata8 MessageData { get; set; }
    }

    public class Response8
    {
        public string _ref { get; set; }
    }

    public class Errorcode8
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds8
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus8
    {
        public string type { get; set; }
    }

    public class Message8
    {
        public string type { get; set; }
    }

    public class Messagedata8
    {
        public string type { get; set; }
        public Additionalproperties8 additionalProperties { get; set; }
    }

    public class Additionalproperties8
    {
        public string type { get; set; }
    }

    public class Parameter6
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class ForumGetpoststhreadedpagedParentpostidPagePagesizeReplysizeGetparentpostRootthreadmodeSortmode
    {
        public Get9 get { get; set; }
    }

    public class Get9
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter7[] parameters { get; set; }
        public Responses9 responses { get; set; }
    }

    public class Responses9
    {
        public _2009 _200 { get; set; }
    }

    public class _2009
    {
        public string description { get; set; }
        public Schema9 schema { get; set; }
    }

    public class Schema9
    {
        public Properties9 properties { get; set; }
    }

    public class Properties9
    {
        public Response9 Response { get; set; }
        public Errorcode9 ErrorCode { get; set; }
        public Throttleseconds9 ThrottleSeconds { get; set; }
        public Errorstatus9 ErrorStatus { get; set; }
        public Message9 Message { get; set; }
        public Messagedata9 MessageData { get; set; }
    }

    public class Response9
    {
        public string _ref { get; set; }
    }

    public class Errorcode9
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds9
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus9
    {
        public string type { get; set; }
    }

    public class Message9
    {
        public string type { get; set; }
    }

    public class Messagedata9
    {
        public string type { get; set; }
        public Additionalproperties9 additionalProperties { get; set; }
    }

    public class Additionalproperties9
    {
        public string type { get; set; }
    }

    public class Parameter7
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class ForumGetpoststhreadedpagedfromchildChildpostidPagePagesizeReplysizeRootthreadmodeSortmode
    {
        public Get10 get { get; set; }
    }

    public class Get10
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter8[] parameters { get; set; }
        public Responses10 responses { get; set; }
    }

    public class Responses10
    {
        public _20010 _200 { get; set; }
    }

    public class _20010
    {
        public string description { get; set; }
        public Schema10 schema { get; set; }
    }

    public class Schema10
    {
        public Properties10 properties { get; set; }
    }

    public class Properties10
    {
        public Response10 Response { get; set; }
        public Errorcode10 ErrorCode { get; set; }
        public Throttleseconds10 ThrottleSeconds { get; set; }
        public Errorstatus10 ErrorStatus { get; set; }
        public Message10 Message { get; set; }
        public Messagedata10 MessageData { get; set; }
    }

    public class Response10
    {
        public string _ref { get; set; }
    }

    public class Errorcode10
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds10
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus10
    {
        public string type { get; set; }
    }

    public class Message10
    {
        public string type { get; set; }
    }

    public class Messagedata10
    {
        public string type { get; set; }
        public Additionalproperties10 additionalProperties { get; set; }
    }

    public class Additionalproperties10
    {
        public string type { get; set; }
    }

    public class Parameter8
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class ForumGetpostandparentChildpostid
    {
        public Get11 get { get; set; }
    }

    public class Get11
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter9[] parameters { get; set; }
        public Responses11 responses { get; set; }
    }

    public class Responses11
    {
        public _20011 _200 { get; set; }
    }

    public class _20011
    {
        public string description { get; set; }
        public Schema11 schema { get; set; }
    }

    public class Schema11
    {
        public Properties11 properties { get; set; }
    }

    public class Properties11
    {
        public Response11 Response { get; set; }
        public Errorcode11 ErrorCode { get; set; }
        public Throttleseconds11 ThrottleSeconds { get; set; }
        public Errorstatus11 ErrorStatus { get; set; }
        public Message11 Message { get; set; }
        public Messagedata11 MessageData { get; set; }
    }

    public class Response11
    {
        public string _ref { get; set; }
    }

    public class Errorcode11
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds11
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus11
    {
        public string type { get; set; }
    }

    public class Message11
    {
        public string type { get; set; }
    }

    public class Messagedata11
    {
        public string type { get; set; }
        public Additionalproperties11 additionalProperties { get; set; }
    }

    public class Additionalproperties11
    {
        public string type { get; set; }
    }

    public class Parameter9
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ForumGetpostandparentawaitingapprovalChildpostid
    {
        public Get12 get { get; set; }
    }

    public class Get12
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter10[] parameters { get; set; }
        public Responses12 responses { get; set; }
    }

    public class Responses12
    {
        public _20012 _200 { get; set; }
    }

    public class _20012
    {
        public string description { get; set; }
        public Schema12 schema { get; set; }
    }

    public class Schema12
    {
        public Properties12 properties { get; set; }
    }

    public class Properties12
    {
        public Response12 Response { get; set; }
        public Errorcode12 ErrorCode { get; set; }
        public Throttleseconds12 ThrottleSeconds { get; set; }
        public Errorstatus12 ErrorStatus { get; set; }
        public Message12 Message { get; set; }
        public Messagedata12 MessageData { get; set; }
    }

    public class Response12
    {
        public string _ref { get; set; }
    }

    public class Errorcode12
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds12
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus12
    {
        public string type { get; set; }
    }

    public class Message12
    {
        public string type { get; set; }
    }

    public class Messagedata12
    {
        public string type { get; set; }
        public Additionalproperties12 additionalProperties { get; set; }
    }

    public class Additionalproperties12
    {
        public string type { get; set; }
    }

    public class Parameter10
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ForumGettopicforcontentContentid
    {
        public Get13 get { get; set; }
    }

    public class Get13
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter11[] parameters { get; set; }
        public Responses13 responses { get; set; }
    }

    public class Responses13
    {
        public _20013 _200 { get; set; }
    }

    public class _20013
    {
        public string description { get; set; }
        public Schema13 schema { get; set; }
    }

    public class Schema13
    {
        public Properties13 properties { get; set; }
    }

    public class Properties13
    {
        public Response13 Response { get; set; }
        public Errorcode13 ErrorCode { get; set; }
        public Throttleseconds13 ThrottleSeconds { get; set; }
        public Errorstatus13 ErrorStatus { get; set; }
        public Message13 Message { get; set; }
        public Messagedata13 MessageData { get; set; }
    }

    public class Response13
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorcode13
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds13
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus13
    {
        public string type { get; set; }
    }

    public class Message13
    {
        public string type { get; set; }
    }

    public class Messagedata13
    {
        public string type { get; set; }
        public Additionalproperties13 additionalProperties { get; set; }
    }

    public class Additionalproperties13
    {
        public string type { get; set; }
    }

    public class Parameter11
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ForumGetforumtagsuggestions
    {
        public Get14 get { get; set; }
    }

    public class Get14
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter12[] parameters { get; set; }
        public Responses14 responses { get; set; }
    }

    public class Responses14
    {
        public _20014 _200 { get; set; }
    }

    public class _20014
    {
        public string description { get; set; }
        public Schema14 schema { get; set; }
    }

    public class Schema14
    {
        public Properties14 properties { get; set; }
    }

    public class Properties14
    {
        public Response14 Response { get; set; }
        public Errorcode14 ErrorCode { get; set; }
        public Throttleseconds14 ThrottleSeconds { get; set; }
        public Errorstatus14 ErrorStatus { get; set; }
        public Message14 Message { get; set; }
        public Messagedata14 MessageData { get; set; }
    }

    public class Response14
    {
        public string type { get; set; }
        public Items4 items { get; set; }
    }

    public class Items4
    {
        public string _ref { get; set; }
    }

    public class Errorcode14
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds14
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus14
    {
        public string type { get; set; }
    }

    public class Message14
    {
        public string type { get; set; }
    }

    public class Messagedata14
    {
        public string type { get; set; }
        public Additionalproperties14 additionalProperties { get; set; }
    }

    public class Additionalproperties14
    {
        public string type { get; set; }
    }

    public class Parameter12
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class ForumPollTopicid
    {
        public Get15 get { get; set; }
    }

    public class Get15
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter13[] parameters { get; set; }
        public Responses15 responses { get; set; }
    }

    public class Responses15
    {
        public _20015 _200 { get; set; }
    }

    public class _20015
    {
        public string description { get; set; }
        public Schema15 schema { get; set; }
    }

    public class Schema15
    {
        public Properties15 properties { get; set; }
    }

    public class Properties15
    {
        public Response15 Response { get; set; }
        public Errorcode15 ErrorCode { get; set; }
        public Throttleseconds15 ThrottleSeconds { get; set; }
        public Errorstatus15 ErrorStatus { get; set; }
        public Message15 Message { get; set; }
        public Messagedata15 MessageData { get; set; }
    }

    public class Response15
    {
        public string _ref { get; set; }
    }

    public class Errorcode15
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds15
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus15
    {
        public string type { get; set; }
    }

    public class Message15
    {
        public string type { get; set; }
    }

    public class Messagedata15
    {
        public string type { get; set; }
        public Additionalproperties15 additionalProperties { get; set; }
    }

    public class Additionalproperties15
    {
        public string type { get; set; }
    }

    public class Parameter13
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class ForumRecruitJoinTopicid
    {
        public Post post { get; set; }
    }

    public class Post
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter14[] parameters { get; set; }
        public Security1[] security { get; set; }
        public Responses16 responses { get; set; }
    }

    public class Responses16
    {
        public _20016 _200 { get; set; }
    }

    public class _20016
    {
        public string description { get; set; }
        public Schema16 schema { get; set; }
    }

    public class Schema16
    {
        public Properties16 properties { get; set; }
    }

    public class Properties16
    {
        public Response16 Response { get; set; }
        public Errorcode16 ErrorCode { get; set; }
        public Throttleseconds16 ThrottleSeconds { get; set; }
        public Errorstatus16 ErrorStatus { get; set; }
        public Message16 Message { get; set; }
        public Messagedata16 MessageData { get; set; }
    }

    public class Response16
    {
        public string _ref { get; set; }
    }

    public class Errorcode16
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds16
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus16
    {
        public string type { get; set; }
    }

    public class Message16
    {
        public string type { get; set; }
    }

    public class Messagedata16
    {
        public string type { get; set; }
        public Additionalproperties16 additionalProperties { get; set; }
    }

    public class Additionalproperties16
    {
        public string type { get; set; }
    }

    public class Parameter14
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Security1
    {
        public string[] oauth2 { get; set; }
    }

    public class ForumRecruitLeaveTopicid
    {
        public Post1 post { get; set; }
    }

    public class Post1
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter15[] parameters { get; set; }
        public Security2[] security { get; set; }
        public Responses17 responses { get; set; }
    }

    public class Responses17
    {
        public _20017 _200 { get; set; }
    }

    public class _20017
    {
        public string description { get; set; }
        public Schema17 schema { get; set; }
    }

    public class Schema17
    {
        public Properties17 properties { get; set; }
    }

    public class Properties17
    {
        public Response17 Response { get; set; }
        public Errorcode17 ErrorCode { get; set; }
        public Throttleseconds17 ThrottleSeconds { get; set; }
        public Errorstatus17 ErrorStatus { get; set; }
        public Message17 Message { get; set; }
        public Messagedata17 MessageData { get; set; }
    }

    public class Response17
    {
        public string _ref { get; set; }
    }

    public class Errorcode17
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds17
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus17
    {
        public string type { get; set; }
    }

    public class Message17
    {
        public string type { get; set; }
    }

    public class Messagedata17
    {
        public string type { get; set; }
        public Additionalproperties17 additionalProperties { get; set; }
    }

    public class Additionalproperties17
    {
        public string type { get; set; }
    }

    public class Parameter15
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Security2
    {
        public string[] oauth2 { get; set; }
    }

    public class ForumRecruitKickbanTopicidTargetmembershipid
    {
        public Post2 post { get; set; }
    }

    public class Post2
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter16[] parameters { get; set; }
        public Security3[] security { get; set; }
        public Responses18 responses { get; set; }
    }

    public class Responses18
    {
        public _20018 _200 { get; set; }
    }

    public class _20018
    {
        public string description { get; set; }
        public Schema18 schema { get; set; }
    }

    public class Schema18
    {
        public Properties18 properties { get; set; }
    }

    public class Properties18
    {
        public Response18 Response { get; set; }
        public Errorcode18 ErrorCode { get; set; }
        public Throttleseconds18 ThrottleSeconds { get; set; }
        public Errorstatus18 ErrorStatus { get; set; }
        public Message18 Message { get; set; }
        public Messagedata18 MessageData { get; set; }
    }

    public class Response18
    {
        public string _ref { get; set; }
    }

    public class Errorcode18
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds18
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus18
    {
        public string type { get; set; }
    }

    public class Message18
    {
        public string type { get; set; }
    }

    public class Messagedata18
    {
        public string type { get; set; }
        public Additionalproperties18 additionalProperties { get; set; }
    }

    public class Additionalproperties18
    {
        public string type { get; set; }
    }

    public class Parameter16
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Security3
    {
        public string[] oauth2 { get; set; }
    }

    public class ForumRecruitApproveTopicid
    {
        public Post3 post { get; set; }
    }

    public class Post3
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter17[] parameters { get; set; }
        public Security4[] security { get; set; }
        public Responses19 responses { get; set; }
    }

    public class Responses19
    {
        public _20019 _200 { get; set; }
    }

    public class _20019
    {
        public string description { get; set; }
        public Schema19 schema { get; set; }
    }

    public class Schema19
    {
        public Properties19 properties { get; set; }
    }

    public class Properties19
    {
        public Response19 Response { get; set; }
        public Errorcode19 ErrorCode { get; set; }
        public Throttleseconds19 ThrottleSeconds { get; set; }
        public Errorstatus19 ErrorStatus { get; set; }
        public Message19 Message { get; set; }
        public Messagedata19 MessageData { get; set; }
    }

    public class Response19
    {
        public string _ref { get; set; }
    }

    public class Errorcode19
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds19
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus19
    {
        public string type { get; set; }
    }

    public class Message19
    {
        public string type { get; set; }
    }

    public class Messagedata19
    {
        public string type { get; set; }
        public Additionalproperties19 additionalProperties { get; set; }
    }

    public class Additionalproperties19
    {
        public string type { get; set; }
    }

    public class Parameter17
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Security4
    {
        public string[] oauth2 { get; set; }
    }

    public class ForumRecruitSummaries
    {
        public Post4 post { get; set; }
    }

    public class Post4
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public object[] parameters { get; set; }
        public Responses20 responses { get; set; }
    }

    public class Responses20
    {
        public _20020 _200 { get; set; }
    }

    public class _20020
    {
        public string description { get; set; }
        public Schema20 schema { get; set; }
    }

    public class Schema20
    {
        public Properties20 properties { get; set; }
    }

    public class Properties20
    {
        public Response20 Response { get; set; }
        public Errorcode20 ErrorCode { get; set; }
        public Throttleseconds20 ThrottleSeconds { get; set; }
        public Errorstatus20 ErrorStatus { get; set; }
        public Message20 Message { get; set; }
        public Messagedata20 MessageData { get; set; }
    }

    public class Response20
    {
        public string type { get; set; }
        public Items5 items { get; set; }
    }

    public class Items5
    {
        public string _ref { get; set; }
    }

    public class Errorcode20
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds20
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus20
    {
        public string type { get; set; }
    }

    public class Message20
    {
        public string type { get; set; }
    }

    public class Messagedata20
    {
        public string type { get; set; }
        public Additionalproperties20 additionalProperties { get; set; }
    }

    public class Additionalproperties20
    {
        public string type { get; set; }
    }

    public class Destiny2Manifest
    {
        public Get16 get { get; set; }
    }

    public class Get16
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public object[] parameters { get; set; }
        public Responses21 responses { get; set; }
    }

    public class Responses21
    {
        public _20021 _200 { get; set; }
    }

    public class _20021
    {
        public string description { get; set; }
        public Schema21 schema { get; set; }
    }

    public class Schema21
    {
        public Properties21 properties { get; set; }
    }

    public class Properties21
    {
        public Response21 Response { get; set; }
        public Errorcode21 ErrorCode { get; set; }
        public Throttleseconds21 ThrottleSeconds { get; set; }
        public Errorstatus21 ErrorStatus { get; set; }
        public Message21 Message { get; set; }
        public Messagedata21 MessageData { get; set; }
    }

    public class Response21
    {
        public string _ref { get; set; }
    }

    public class Errorcode21
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds21
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus21
    {
        public string type { get; set; }
    }

    public class Message21
    {
        public string type { get; set; }
    }

    public class Messagedata21
    {
        public string type { get; set; }
        public Additionalproperties21 additionalProperties { get; set; }
    }

    public class Additionalproperties21
    {
        public string type { get; set; }
    }

    public class Destiny2SearchdestinyplayerMembershiptypeDisplayname
    {
        public Get17 get { get; set; }
    }

    public class Get17
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter18[] parameters { get; set; }
        public Responses22 responses { get; set; }
    }

    public class Responses22
    {
        public _20022 _200 { get; set; }
    }

    public class _20022
    {
        public string description { get; set; }
        public Schema22 schema { get; set; }
    }

    public class Schema22
    {
        public Properties22 properties { get; set; }
    }

    public class Properties22
    {
        public Response22 Response { get; set; }
        public Errorcode22 ErrorCode { get; set; }
        public Throttleseconds22 ThrottleSeconds { get; set; }
        public Errorstatus22 ErrorStatus { get; set; }
        public Message22 Message { get; set; }
        public Messagedata22 MessageData { get; set; }
    }

    public class Response22
    {
        public string type { get; set; }
        public Items6 items { get; set; }
    }

    public class Items6
    {
        public string _ref { get; set; }
    }

    public class Errorcode22
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds22
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus22
    {
        public string type { get; set; }
    }

    public class Message22
    {
        public string type { get; set; }
    }

    public class Messagedata22
    {
        public string type { get; set; }
        public Additionalproperties22 additionalProperties { get; set; }
    }

    public class Additionalproperties22
    {
        public string type { get; set; }
    }

    public class Parameter18
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class Destiny2MembershiptypeProfileDestinymembershipid
    {
        public Get18 get { get; set; }
    }

    public class Get18
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter19[] parameters { get; set; }
        public Responses23 responses { get; set; }
    }

    public class Responses23
    {
        public _20023 _200 { get; set; }
    }

    public class _20023
    {
        public string description { get; set; }
        public Schema23 schema { get; set; }
    }

    public class Schema23
    {
        public Properties23 properties { get; set; }
    }

    public class Properties23
    {
        public Response23 Response { get; set; }
        public Errorcode23 ErrorCode { get; set; }
        public Throttleseconds23 ThrottleSeconds { get; set; }
        public Errorstatus23 ErrorStatus { get; set; }
        public Message23 Message { get; set; }
        public Messagedata23 MessageData { get; set; }
    }

    public class Response23
    {
        public string _ref { get; set; }
    }

    public class Errorcode23
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds23
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus23
    {
        public string type { get; set; }
    }

    public class Message23
    {
        public string type { get; set; }
    }

    public class Messagedata23
    {
        public string type { get; set; }
        public Additionalproperties23 additionalProperties { get; set; }
    }

    public class Additionalproperties23
    {
        public string type { get; set; }
    }

    public class Parameter19
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Items7 items { get; set; }
        public bool required { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class Items7
    {
        public string _ref { get; set; }
    }

    public class Destiny2MembershiptypeProfileDestinymembershipidCharacterCharacterid
    {
        public Get19 get { get; set; }
    }

    public class Get19
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter20[] parameters { get; set; }
        public Responses24 responses { get; set; }
    }

    public class Responses24
    {
        public _20024 _200 { get; set; }
    }

    public class _20024
    {
        public string description { get; set; }
        public Schema24 schema { get; set; }
    }

    public class Schema24
    {
        public Properties24 properties { get; set; }
    }

    public class Properties24
    {
        public Response24 Response { get; set; }
        public Errorcode24 ErrorCode { get; set; }
        public Throttleseconds24 ThrottleSeconds { get; set; }
        public Errorstatus24 ErrorStatus { get; set; }
        public Message24 Message { get; set; }
        public Messagedata24 MessageData { get; set; }
    }

    public class Response24
    {
        public string _ref { get; set; }
    }

    public class Errorcode24
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds24
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus24
    {
        public string type { get; set; }
    }

    public class Message24
    {
        public string type { get; set; }
    }

    public class Messagedata24
    {
        public string type { get; set; }
        public Additionalproperties24 additionalProperties { get; set; }
    }

    public class Additionalproperties24
    {
        public string type { get; set; }
    }

    public class Parameter20
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public Items8 items { get; set; }
        public string[] _enum { get; set; }
    }

    public class Items8
    {
        public string _ref { get; set; }
    }

    public class Destiny2ClanGroupidWeeklyrewardstate
    {
        public Get20 get { get; set; }
    }

    public class Get20
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter21[] parameters { get; set; }
        public Responses25 responses { get; set; }
    }

    public class Responses25
    {
        public _20025 _200 { get; set; }
    }

    public class _20025
    {
        public string description { get; set; }
        public Schema25 schema { get; set; }
    }

    public class Schema25
    {
        public Properties25 properties { get; set; }
    }

    public class Properties25
    {
        public Response25 Response { get; set; }
        public Errorcode25 ErrorCode { get; set; }
        public Throttleseconds25 ThrottleSeconds { get; set; }
        public Errorstatus25 ErrorStatus { get; set; }
        public Message25 Message { get; set; }
        public Messagedata25 MessageData { get; set; }
    }

    public class Response25
    {
        public string _ref { get; set; }
    }

    public class Errorcode25
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds25
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus25
    {
        public string type { get; set; }
    }

    public class Message25
    {
        public string type { get; set; }
    }

    public class Messagedata25
    {
        public string type { get; set; }
        public Additionalproperties25 additionalProperties { get; set; }
    }

    public class Additionalproperties25
    {
        public string type { get; set; }
    }

    public class Parameter21
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Destiny2MembershiptypeProfileDestinymembershipidItemIteminstanceid
    {
        public Get21 get { get; set; }
    }

    public class Get21
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter22[] parameters { get; set; }
        public Responses26 responses { get; set; }
    }

    public class Responses26
    {
        public _20026 _200 { get; set; }
    }

    public class _20026
    {
        public string description { get; set; }
        public Schema26 schema { get; set; }
    }

    public class Schema26
    {
        public Properties26 properties { get; set; }
    }

    public class Properties26
    {
        public Response26 Response { get; set; }
        public Errorcode26 ErrorCode { get; set; }
        public Throttleseconds26 ThrottleSeconds { get; set; }
        public Errorstatus26 ErrorStatus { get; set; }
        public Message26 Message { get; set; }
        public Messagedata26 MessageData { get; set; }
    }

    public class Response26
    {
        public string _ref { get; set; }
    }

    public class Errorcode26
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds26
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus26
    {
        public string type { get; set; }
    }

    public class Message26
    {
        public string type { get; set; }
    }

    public class Messagedata26
    {
        public string type { get; set; }
        public Additionalproperties26 additionalProperties { get; set; }
    }

    public class Additionalproperties26
    {
        public string type { get; set; }
    }

    public class Parameter22
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public Items9 items { get; set; }
        public bool required { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class Items9
    {
        public string _ref { get; set; }
    }

    public class Destiny2MembershiptypeProfileDestinymembershipidCharacterCharacteridVendors
    {
        public Get22 get { get; set; }
    }

    public class Get22
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter23[] parameters { get; set; }
        public Responses27 responses { get; set; }
        public bool xpreview { get; set; }
    }

    public class Responses27
    {
        public _20027 _200 { get; set; }
    }

    public class _20027
    {
        public string description { get; set; }
        public Schema27 schema { get; set; }
    }

    public class Schema27
    {
        public Properties27 properties { get; set; }
    }

    public class Properties27
    {
        public Response27 Response { get; set; }
        public Errorcode27 ErrorCode { get; set; }
        public Throttleseconds27 ThrottleSeconds { get; set; }
        public Errorstatus27 ErrorStatus { get; set; }
        public Message27 Message { get; set; }
        public Messagedata27 MessageData { get; set; }
    }

    public class Response27
    {
        public string type { get; set; }
        public Items10 items { get; set; }
    }

    public class Items10
    {
        public string _ref { get; set; }
    }

    public class Errorcode27
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds27
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus27
    {
        public string type { get; set; }
    }

    public class Message27
    {
        public string type { get; set; }
    }

    public class Messagedata27
    {
        public string type { get; set; }
        public Additionalproperties27 additionalProperties { get; set; }
    }

    public class Additionalproperties27
    {
        public string type { get; set; }
    }

    public class Parameter23
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public Items11 items { get; set; }
        public string[] _enum { get; set; }
    }

    public class Items11
    {
        public string _ref { get; set; }
    }

    public class Destiny2MembershiptypeProfileDestinymembershipidCharacterCharacteridVendorsVendorhash
    {
        public Get23 get { get; set; }
    }

    public class Get23
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter24[] parameters { get; set; }
        public Responses28 responses { get; set; }
        public bool xpreview { get; set; }
    }

    public class Responses28
    {
        public _20028 _200 { get; set; }
    }

    public class _20028
    {
        public string description { get; set; }
        public Schema28 schema { get; set; }
    }

    public class Schema28
    {
        public Properties28 properties { get; set; }
    }

    public class Properties28
    {
        public Response28 Response { get; set; }
        public Errorcode28 ErrorCode { get; set; }
        public Throttleseconds28 ThrottleSeconds { get; set; }
        public Errorstatus28 ErrorStatus { get; set; }
        public Message28 Message { get; set; }
        public Messagedata28 MessageData { get; set; }
    }

    public class Response28
    {
        public string _ref { get; set; }
    }

    public class Errorcode28
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds28
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus28
    {
        public string type { get; set; }
    }

    public class Message28
    {
        public string type { get; set; }
    }

    public class Messagedata28
    {
        public string type { get; set; }
        public Additionalproperties28 additionalProperties { get; set; }
    }

    public class Additionalproperties28
    {
        public string type { get; set; }
    }

    public class Parameter24
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public Items12 items { get; set; }
        public string[] _enum { get; set; }
    }

    public class Items12
    {
        public string _ref { get; set; }
    }

    public class Destiny2ActionsItemsTransferitem
    {
        public Post5 post { get; set; }
    }

    public class Post5
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public object[] parameters { get; set; }
        public Security5[] security { get; set; }
        public Responses29 responses { get; set; }
    }

    public class Responses29
    {
        public _20029 _200 { get; set; }
    }

    public class _20029
    {
        public string description { get; set; }
        public Schema29 schema { get; set; }
    }

    public class Schema29
    {
        public Properties29 properties { get; set; }
    }

    public class Properties29
    {
        public Response29 Response { get; set; }
        public Errorcode29 ErrorCode { get; set; }
        public Throttleseconds29 ThrottleSeconds { get; set; }
        public Errorstatus29 ErrorStatus { get; set; }
        public Message29 Message { get; set; }
        public Messagedata29 MessageData { get; set; }
    }

    public class Response29
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorcode29
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds29
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus29
    {
        public string type { get; set; }
    }

    public class Message29
    {
        public string type { get; set; }
    }

    public class Messagedata29
    {
        public string type { get; set; }
        public Additionalproperties29 additionalProperties { get; set; }
    }

    public class Additionalproperties29
    {
        public string type { get; set; }
    }

    public class Security5
    {
        public string[] oauth2 { get; set; }
    }

    public class Destiny2ActionsItemsEquipitem
    {
        public Post6 post { get; set; }
    }

    public class Post6
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public object[] parameters { get; set; }
        public Security6[] security { get; set; }
        public Responses30 responses { get; set; }
    }

    public class Responses30
    {
        public _20030 _200 { get; set; }
    }

    public class _20030
    {
        public string description { get; set; }
        public Schema30 schema { get; set; }
    }

    public class Schema30
    {
        public Properties30 properties { get; set; }
    }

    public class Properties30
    {
        public Response30 Response { get; set; }
        public Errorcode30 ErrorCode { get; set; }
        public Throttleseconds30 ThrottleSeconds { get; set; }
        public Errorstatus30 ErrorStatus { get; set; }
        public Message30 Message { get; set; }
        public Messagedata30 MessageData { get; set; }
    }

    public class Response30
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorcode30
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds30
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus30
    {
        public string type { get; set; }
    }

    public class Message30
    {
        public string type { get; set; }
    }

    public class Messagedata30
    {
        public string type { get; set; }
        public Additionalproperties30 additionalProperties { get; set; }
    }

    public class Additionalproperties30
    {
        public string type { get; set; }
    }

    public class Security6
    {
        public string[] oauth2 { get; set; }
    }

    public class Destiny2ActionsItemsEquipitems
    {
        public Post7 post { get; set; }
    }

    public class Post7
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public object[] parameters { get; set; }
        public Security7[] security { get; set; }
        public Responses31 responses { get; set; }
    }

    public class Responses31
    {
        public _20031 _200 { get; set; }
    }

    public class _20031
    {
        public string description { get; set; }
        public Schema31 schema { get; set; }
    }

    public class Schema31
    {
        public Properties31 properties { get; set; }
    }

    public class Properties31
    {
        public Response31 Response { get; set; }
        public Errorcode31 ErrorCode { get; set; }
        public Throttleseconds31 ThrottleSeconds { get; set; }
        public Errorstatus31 ErrorStatus { get; set; }
        public Message31 Message { get; set; }
        public Messagedata31 MessageData { get; set; }
    }

    public class Response31
    {
        public string _ref { get; set; }
    }

    public class Errorcode31
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds31
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus31
    {
        public string type { get; set; }
    }

    public class Message31
    {
        public string type { get; set; }
    }

    public class Messagedata31
    {
        public string type { get; set; }
        public Additionalproperties31 additionalProperties { get; set; }
    }

    public class Additionalproperties31
    {
        public string type { get; set; }
    }

    public class Security7
    {
        public string[] oauth2 { get; set; }
    }

    public class Destiny2ActionsItemsSetlockstate
    {
        public Post8 post { get; set; }
    }

    public class Post8
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public object[] parameters { get; set; }
        public Security8[] security { get; set; }
        public Responses32 responses { get; set; }
    }

    public class Responses32
    {
        public _20032 _200 { get; set; }
    }

    public class _20032
    {
        public string description { get; set; }
        public Schema32 schema { get; set; }
    }

    public class Schema32
    {
        public Properties32 properties { get; set; }
    }

    public class Properties32
    {
        public Response32 Response { get; set; }
        public Errorcode32 ErrorCode { get; set; }
        public Throttleseconds32 ThrottleSeconds { get; set; }
        public Errorstatus32 ErrorStatus { get; set; }
        public Message32 Message { get; set; }
        public Messagedata32 MessageData { get; set; }
    }

    public class Response32
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorcode32
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds32
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus32
    {
        public string type { get; set; }
    }

    public class Message32
    {
        public string type { get; set; }
    }

    public class Messagedata32
    {
        public string type { get; set; }
        public Additionalproperties32 additionalProperties { get; set; }
    }

    public class Additionalproperties32
    {
        public string type { get; set; }
    }

    public class Security8
    {
        public string[] oauth2 { get; set; }
    }

    public class Destiny2ActionsItemsInsertsocketplug
    {
        public Post9 post { get; set; }
    }

    public class Post9
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public object[] parameters { get; set; }
        public Security9[] security { get; set; }
        public Responses33 responses { get; set; }
        public bool xpreview { get; set; }
    }

    public class Responses33
    {
        public _20033 _200 { get; set; }
    }

    public class _20033
    {
        public string description { get; set; }
        public Schema33 schema { get; set; }
    }

    public class Schema33
    {
        public Properties33 properties { get; set; }
    }

    public class Properties33
    {
        public Response33 Response { get; set; }
        public Errorcode33 ErrorCode { get; set; }
        public Throttleseconds33 ThrottleSeconds { get; set; }
        public Errorstatus33 ErrorStatus { get; set; }
        public Message33 Message { get; set; }
        public Messagedata33 MessageData { get; set; }
    }

    public class Response33
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorcode33
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds33
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus33
    {
        public string type { get; set; }
    }

    public class Message33
    {
        public string type { get; set; }
    }

    public class Messagedata33
    {
        public string type { get; set; }
        public Additionalproperties33 additionalProperties { get; set; }
    }

    public class Additionalproperties33
    {
        public string type { get; set; }
    }

    public class Security9
    {
        public string[] oauth2 { get; set; }
    }

    public class Destiny2ActionsItemsActivatetalentnode
    {
        public Post10 post { get; set; }
    }

    public class Post10
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public object[] parameters { get; set; }
        public Security10[] security { get; set; }
        public Responses34 responses { get; set; }
        public bool xpreview { get; set; }
    }

    public class Responses34
    {
        public _20034 _200 { get; set; }
    }

    public class _20034
    {
        public string description { get; set; }
        public Schema34 schema { get; set; }
    }

    public class Schema34
    {
        public Properties34 properties { get; set; }
    }

    public class Properties34
    {
        public Response34 Response { get; set; }
        public Errorcode34 ErrorCode { get; set; }
        public Throttleseconds34 ThrottleSeconds { get; set; }
        public Errorstatus34 ErrorStatus { get; set; }
        public Message34 Message { get; set; }
        public Messagedata34 MessageData { get; set; }
    }

    public class Response34
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorcode34
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds34
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus34
    {
        public string type { get; set; }
    }

    public class Message34
    {
        public string type { get; set; }
    }

    public class Messagedata34
    {
        public string type { get; set; }
        public Additionalproperties34 additionalProperties { get; set; }
    }

    public class Additionalproperties34
    {
        public string type { get; set; }
    }

    public class Security10
    {
        public string[] oauth2 { get; set; }
    }

    public class Destiny2StatsPostgamecarnagereportActivityid
    {
        public Get24 get { get; set; }
    }

    public class Get24
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter25[] parameters { get; set; }
        public Responses35 responses { get; set; }
    }

    public class Responses35
    {
        public _20035 _200 { get; set; }
    }

    public class _20035
    {
        public string description { get; set; }
        public Schema35 schema { get; set; }
    }

    public class Schema35
    {
        public Properties35 properties { get; set; }
    }

    public class Properties35
    {
        public Response35 Response { get; set; }
        public Errorcode35 ErrorCode { get; set; }
        public Throttleseconds35 ThrottleSeconds { get; set; }
        public Errorstatus35 ErrorStatus { get; set; }
        public Message35 Message { get; set; }
        public Messagedata35 MessageData { get; set; }
    }

    public class Response35
    {
        public string _ref { get; set; }
    }

    public class Errorcode35
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds35
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus35
    {
        public string type { get; set; }
    }

    public class Message35
    {
        public string type { get; set; }
    }

    public class Messagedata35
    {
        public string type { get; set; }
        public Additionalproperties35 additionalProperties { get; set; }
    }

    public class Additionalproperties35
    {
        public string type { get; set; }
    }

    public class Parameter25
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Destiny2StatsDefinition
    {
        public Get25 get { get; set; }
    }

    public class Get25
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public object[] parameters { get; set; }
        public Responses36 responses { get; set; }
    }

    public class Responses36
    {
        public _20036 _200 { get; set; }
    }

    public class _20036
    {
        public string description { get; set; }
        public Schema36 schema { get; set; }
    }

    public class Schema36
    {
        public Properties36 properties { get; set; }
    }

    public class Properties36
    {
        public Response36 Response { get; set; }
        public Errorcode36 ErrorCode { get; set; }
        public Throttleseconds36 ThrottleSeconds { get; set; }
        public Errorstatus36 ErrorStatus { get; set; }
        public Message36 Message { get; set; }
        public Messagedata36 MessageData { get; set; }
    }

    public class Response36
    {
        public string type { get; set; }
        public Additionalproperties36 additionalProperties { get; set; }
    }

    public class Additionalproperties36
    {
        public string _ref { get; set; }
    }

    public class Errorcode36
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds36
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus36
    {
        public string type { get; set; }
    }

    public class Message36
    {
        public string type { get; set; }
    }

    public class Messagedata36
    {
        public string type { get; set; }
        public Additionalproperties37 additionalProperties { get; set; }
    }

    public class Additionalproperties37
    {
        public string type { get; set; }
    }

    public class Destiny2StatsLeaderboardsClansGroupid
    {
        public Get26 get { get; set; }
    }

    public class Get26
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter26[] parameters { get; set; }
        public Responses37 responses { get; set; }
        public bool xpreview { get; set; }
    }

    public class Responses37
    {
        public _20037 _200 { get; set; }
    }

    public class _20037
    {
        public string description { get; set; }
        public Schema37 schema { get; set; }
    }

    public class Schema37
    {
        public Properties37 properties { get; set; }
    }

    public class Properties37
    {
        public Response37 Response { get; set; }
        public Errorcode37 ErrorCode { get; set; }
        public Throttleseconds37 ThrottleSeconds { get; set; }
        public Errorstatus37 ErrorStatus { get; set; }
        public Message37 Message { get; set; }
        public Messagedata37 MessageData { get; set; }
    }

    public class Response37
    {
        public string type { get; set; }
        public Additionalproperties38 additionalProperties { get; set; }
    }

    public class Additionalproperties38
    {
        public string type { get; set; }
        public Additionalproperties39 additionalProperties { get; set; }
    }

    public class Additionalproperties39
    {
        public string _ref { get; set; }
    }

    public class Errorcode37
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds37
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus37
    {
        public string type { get; set; }
    }

    public class Message37
    {
        public string type { get; set; }
    }

    public class Messagedata37
    {
        public string type { get; set; }
        public Additionalproperties40 additionalProperties { get; set; }
    }

    public class Additionalproperties40
    {
        public string type { get; set; }
    }

    public class Parameter26
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Destiny2StatsAggregateclanstatsGroupid
    {
        public Get27 get { get; set; }
    }

    public class Get27
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter27[] parameters { get; set; }
        public Responses38 responses { get; set; }
        public bool xpreview { get; set; }
    }

    public class Responses38
    {
        public _20038 _200 { get; set; }
    }

    public class _20038
    {
        public string description { get; set; }
        public Schema38 schema { get; set; }
    }

    public class Schema38
    {
        public Properties38 properties { get; set; }
    }

    public class Properties38
    {
        public Response38 Response { get; set; }
        public Errorcode38 ErrorCode { get; set; }
        public Throttleseconds38 ThrottleSeconds { get; set; }
        public Errorstatus38 ErrorStatus { get; set; }
        public Message38 Message { get; set; }
        public Messagedata38 MessageData { get; set; }
    }

    public class Response38
    {
        public string type { get; set; }
        public Items13 items { get; set; }
    }

    public class Items13
    {
        public string _ref { get; set; }
    }

    public class Errorcode38
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds38
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus38
    {
        public string type { get; set; }
    }

    public class Message38
    {
        public string type { get; set; }
    }

    public class Messagedata38
    {
        public string type { get; set; }
        public Additionalproperties41 additionalProperties { get; set; }
    }

    public class Additionalproperties41
    {
        public string type { get; set; }
    }

    public class Parameter27
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Destiny2MembershiptypeAccountDestinymembershipidStatsLeaderboards
    {
        public Get28 get { get; set; }
    }

    public class Get28
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter28[] parameters { get; set; }
        public Responses39 responses { get; set; }
        public bool xpreview { get; set; }
    }

    public class Responses39
    {
        public _20039 _200 { get; set; }
    }

    public class _20039
    {
        public string description { get; set; }
        public Schema39 schema { get; set; }
    }

    public class Schema39
    {
        public Properties39 properties { get; set; }
    }

    public class Properties39
    {
        public Response39 Response { get; set; }
        public Errorcode39 ErrorCode { get; set; }
        public Throttleseconds39 ThrottleSeconds { get; set; }
        public Errorstatus39 ErrorStatus { get; set; }
        public Message39 Message { get; set; }
        public Messagedata39 MessageData { get; set; }
    }

    public class Response39
    {
        public string type { get; set; }
        public Additionalproperties42 additionalProperties { get; set; }
    }

    public class Additionalproperties42
    {
        public string type { get; set; }
        public Additionalproperties43 additionalProperties { get; set; }
    }

    public class Additionalproperties43
    {
        public string _ref { get; set; }
    }

    public class Errorcode39
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds39
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus39
    {
        public string type { get; set; }
    }

    public class Message39
    {
        public string type { get; set; }
    }

    public class Messagedata39
    {
        public string type { get; set; }
        public Additionalproperties44 additionalProperties { get; set; }
    }

    public class Additionalproperties44
    {
        public string type { get; set; }
    }

    public class Parameter28
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class Destiny2StatsLeaderboardsMembershiptypeDestinymembershipidCharacterid
    {
        public Get29 get { get; set; }
    }

    public class Get29
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter29[] parameters { get; set; }
        public Responses40 responses { get; set; }
        public bool xpreview { get; set; }
    }

    public class Responses40
    {
        public _20040 _200 { get; set; }
    }

    public class _20040
    {
        public string description { get; set; }
        public Schema40 schema { get; set; }
    }

    public class Schema40
    {
        public Properties40 properties { get; set; }
    }

    public class Properties40
    {
        public Response40 Response { get; set; }
        public Errorcode40 ErrorCode { get; set; }
        public Throttleseconds40 ThrottleSeconds { get; set; }
        public Errorstatus40 ErrorStatus { get; set; }
        public Message40 Message { get; set; }
        public Messagedata40 MessageData { get; set; }
    }

    public class Response40
    {
        public string type { get; set; }
        public Additionalproperties45 additionalProperties { get; set; }
    }

    public class Additionalproperties45
    {
        public string type { get; set; }
        public Additionalproperties46 additionalProperties { get; set; }
    }

    public class Additionalproperties46
    {
        public string _ref { get; set; }
    }

    public class Errorcode40
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds40
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus40
    {
        public string type { get; set; }
    }

    public class Message40
    {
        public string type { get; set; }
    }

    public class Messagedata40
    {
        public string type { get; set; }
        public Additionalproperties47 additionalProperties { get; set; }
    }

    public class Additionalproperties47
    {
        public string type { get; set; }
    }

    public class Parameter29
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class Destiny2ArmorySearchTypeSearchterm
    {
        public Get30 get { get; set; }
    }

    public class Get30
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter30[] parameters { get; set; }
        public Responses41 responses { get; set; }
        public bool xpreview { get; set; }
    }

    public class Responses41
    {
        public _20041 _200 { get; set; }
    }

    public class _20041
    {
        public string description { get; set; }
        public Schema41 schema { get; set; }
    }

    public class Schema41
    {
        public Properties41 properties { get; set; }
    }

    public class Properties41
    {
        public Response41 Response { get; set; }
        public Errorcode41 ErrorCode { get; set; }
        public Throttleseconds41 ThrottleSeconds { get; set; }
        public Errorstatus41 ErrorStatus { get; set; }
        public Message41 Message { get; set; }
        public Messagedata41 MessageData { get; set; }
    }

    public class Response41
    {
        public string _ref { get; set; }
    }

    public class Errorcode41
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds41
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus41
    {
        public string type { get; set; }
    }

    public class Message41
    {
        public string type { get; set; }
    }

    public class Messagedata41
    {
        public string type { get; set; }
        public Additionalproperties48 additionalProperties { get; set; }
    }

    public class Additionalproperties48
    {
        public string type { get; set; }
    }

    public class Parameter30
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public bool required { get; set; }
    }

    public class Destiny2MembershiptypeAccountDestinymembershipidCharacterCharacteridStats
    {
        public Get31 get { get; set; }
    }

    public class Get31
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter31[] parameters { get; set; }
        public Responses42 responses { get; set; }
        public bool xpreview { get; set; }
    }

    public class Responses42
    {
        public _20042 _200 { get; set; }
    }

    public class _20042
    {
        public string description { get; set; }
        public Schema42 schema { get; set; }
    }

    public class Schema42
    {
        public Properties42 properties { get; set; }
    }

    public class Properties42
    {
        public Response42 Response { get; set; }
        public Errorcode42 ErrorCode { get; set; }
        public Throttleseconds42 ThrottleSeconds { get; set; }
        public Errorstatus42 ErrorStatus { get; set; }
        public Message42 Message { get; set; }
        public Messagedata42 MessageData { get; set; }
    }

    public class Response42
    {
        public string type { get; set; }
        public Additionalproperties49 additionalProperties { get; set; }
    }

    public class Additionalproperties49
    {
        public string _ref { get; set; }
    }

    public class Errorcode42
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds42
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus42
    {
        public string type { get; set; }
    }

    public class Message42
    {
        public string type { get; set; }
    }

    public class Messagedata42
    {
        public string type { get; set; }
        public Additionalproperties50 additionalProperties { get; set; }
    }

    public class Additionalproperties50
    {
        public string type { get; set; }
    }

    public class Parameter31
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public Items14 items { get; set; }
        public string[] _enum { get; set; }
    }

    public class Items14
    {
        public string _ref { get; set; }
    }

    public class Destiny2MembershiptypeAccountDestinymembershipidStats
    {
        public Get32 get { get; set; }
    }

    public class Get32
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter32[] parameters { get; set; }
        public Responses43 responses { get; set; }
        public bool xpreview { get; set; }
    }

    public class Responses43
    {
        public _20043 _200 { get; set; }
    }

    public class _20043
    {
        public string description { get; set; }
        public Schema43 schema { get; set; }
    }

    public class Schema43
    {
        public Properties43 properties { get; set; }
    }

    public class Properties43
    {
        public Response43 Response { get; set; }
        public Errorcode43 ErrorCode { get; set; }
        public Throttleseconds43 ThrottleSeconds { get; set; }
        public Errorstatus43 ErrorStatus { get; set; }
        public Message43 Message { get; set; }
        public Messagedata43 MessageData { get; set; }
    }

    public class Response43
    {
        public string _ref { get; set; }
    }

    public class Errorcode43
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds43
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus43
    {
        public string type { get; set; }
    }

    public class Message43
    {
        public string type { get; set; }
    }

    public class Messagedata43
    {
        public string type { get; set; }
        public Additionalproperties51 additionalProperties { get; set; }
    }

    public class Additionalproperties51
    {
        public string type { get; set; }
    }

    public class Parameter32
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public Items15 items { get; set; }
        public string[] _enum { get; set; }
    }

    public class Items15
    {
        public string _ref { get; set; }
    }

    public class Destiny2MembershiptypeAccountDestinymembershipidCharacterCharacteridStatsActivities
    {
        public Get33 get { get; set; }
    }

    public class Get33
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter33[] parameters { get; set; }
        public Responses44 responses { get; set; }
        public bool xpreview { get; set; }
    }

    public class Responses44
    {
        public _20044 _200 { get; set; }
    }

    public class _20044
    {
        public string description { get; set; }
        public Schema44 schema { get; set; }
    }

    public class Schema44
    {
        public Properties44 properties { get; set; }
    }

    public class Properties44
    {
        public Response44 Response { get; set; }
        public Errorcode44 ErrorCode { get; set; }
        public Throttleseconds44 ThrottleSeconds { get; set; }
        public Errorstatus44 ErrorStatus { get; set; }
        public Message44 Message { get; set; }
        public Messagedata44 MessageData { get; set; }
    }

    public class Response44
    {
        public string _ref { get; set; }
    }

    public class Errorcode44
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds44
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus44
    {
        public string type { get; set; }
    }

    public class Message44
    {
        public string type { get; set; }
    }

    public class Messagedata44
    {
        public string type { get; set; }
        public Additionalproperties52 additionalProperties { get; set; }
    }

    public class Additionalproperties52
    {
        public string type { get; set; }
    }

    public class Parameter33
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class Destiny2MembershiptypeAccountDestinymembershipidCharacterCharacteridStatsUniqueweapons
    {
        public Get34 get { get; set; }
    }

    public class Get34
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter34[] parameters { get; set; }
        public Responses45 responses { get; set; }
        public bool xpreview { get; set; }
    }

    public class Responses45
    {
        public _20045 _200 { get; set; }
    }

    public class _20045
    {
        public string description { get; set; }
        public Schema45 schema { get; set; }
    }

    public class Schema45
    {
        public Properties45 properties { get; set; }
    }

    public class Properties45
    {
        public Response45 Response { get; set; }
        public Errorcode45 ErrorCode { get; set; }
        public Throttleseconds45 ThrottleSeconds { get; set; }
        public Errorstatus45 ErrorStatus { get; set; }
        public Message45 Message { get; set; }
        public Messagedata45 MessageData { get; set; }
    }

    public class Response45
    {
        public string _ref { get; set; }
    }

    public class Errorcode45
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds45
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus45
    {
        public string type { get; set; }
    }

    public class Message45
    {
        public string type { get; set; }
    }

    public class Messagedata45
    {
        public string type { get; set; }
        public Additionalproperties53 additionalProperties { get; set; }
    }

    public class Additionalproperties53
    {
        public string type { get; set; }
    }

    public class Parameter34
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class Destiny2MembershiptypeAccountDestinymembershipidCharacterCharacteridStatsAggregateactivitystats
    {
        public Get35 get { get; set; }
    }

    public class Get35
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter35[] parameters { get; set; }
        public Responses46 responses { get; set; }
        public bool xpreview { get; set; }
    }

    public class Responses46
    {
        public _20046 _200 { get; set; }
    }

    public class _20046
    {
        public string description { get; set; }
        public Schema46 schema { get; set; }
    }

    public class Schema46
    {
        public Properties46 properties { get; set; }
    }

    public class Properties46
    {
        public Response46 Response { get; set; }
        public Errorcode46 ErrorCode { get; set; }
        public Throttleseconds46 ThrottleSeconds { get; set; }
        public Errorstatus46 ErrorStatus { get; set; }
        public Message46 Message { get; set; }
        public Messagedata46 MessageData { get; set; }
    }

    public class Response46
    {
        public string _ref { get; set; }
    }

    public class Errorcode46
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds46
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus46
    {
        public string type { get; set; }
    }

    public class Message46
    {
        public string type { get; set; }
    }

    public class Messagedata46
    {
        public string type { get; set; }
        public Additionalproperties54 additionalProperties { get; set; }
    }

    public class Additionalproperties54
    {
        public string type { get; set; }
    }

    public class Parameter35
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class Destiny2MilestonesMilestonehashContent
    {
        public Get36 get { get; set; }
    }

    public class Get36
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter36[] parameters { get; set; }
        public Responses47 responses { get; set; }
    }

    public class Responses47
    {
        public _20047 _200 { get; set; }
    }

    public class _20047
    {
        public string description { get; set; }
        public Schema47 schema { get; set; }
    }

    public class Schema47
    {
        public Properties47 properties { get; set; }
    }

    public class Properties47
    {
        public Response47 Response { get; set; }
        public Errorcode47 ErrorCode { get; set; }
        public Throttleseconds47 ThrottleSeconds { get; set; }
        public Errorstatus47 ErrorStatus { get; set; }
        public Message47 Message { get; set; }
        public Messagedata47 MessageData { get; set; }
    }

    public class Response47
    {
        public string _ref { get; set; }
    }

    public class Errorcode47
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds47
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus47
    {
        public string type { get; set; }
    }

    public class Message47
    {
        public string type { get; set; }
    }

    public class Messagedata47
    {
        public string type { get; set; }
        public Additionalproperties55 additionalProperties { get; set; }
    }

    public class Additionalproperties55
    {
        public string type { get; set; }
    }

    public class Parameter36
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class Destiny2Milestones
    {
        public Get37 get { get; set; }
    }

    public class Get37
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public object[] parameters { get; set; }
        public Responses48 responses { get; set; }
    }

    public class Responses48
    {
        public _20048 _200 { get; set; }
    }

    public class _20048
    {
        public string description { get; set; }
        public Schema48 schema { get; set; }
    }

    public class Schema48
    {
        public Properties48 properties { get; set; }
    }

    public class Properties48
    {
        public Response48 Response { get; set; }
        public Errorcode48 ErrorCode { get; set; }
        public Throttleseconds48 ThrottleSeconds { get; set; }
        public Errorstatus48 ErrorStatus { get; set; }
        public Message48 Message { get; set; }
        public Messagedata48 MessageData { get; set; }
    }

    public class Response48
    {
        public string type { get; set; }
        public Additionalproperties56 additionalProperties { get; set; }
    }

    public class Additionalproperties56
    {
        public string _ref { get; set; }
    }

    public class Errorcode48
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds48
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus48
    {
        public string type { get; set; }
    }

    public class Message48
    {
        public string type { get; set; }
    }

    public class Messagedata48
    {
        public string type { get; set; }
        public Additionalproperties57 additionalProperties { get; set; }
    }

    public class Additionalproperties57
    {
        public string type { get; set; }
    }

    public class CommunitycontentGetSortMediafilterPage
    {
        public Get38 get { get; set; }
    }

    public class Get38
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter37[] parameters { get; set; }
        public Responses49 responses { get; set; }
    }

    public class Responses49
    {
        public _20049 _200 { get; set; }
    }

    public class _20049
    {
        public string description { get; set; }
        public Schema49 schema { get; set; }
    }

    public class Schema49
    {
        public Properties49 properties { get; set; }
    }

    public class Properties49
    {
        public Response49 Response { get; set; }
        public Errorcode49 ErrorCode { get; set; }
        public Throttleseconds49 ThrottleSeconds { get; set; }
        public Errorstatus49 ErrorStatus { get; set; }
        public Message49 Message { get; set; }
        public Messagedata49 MessageData { get; set; }
    }

    public class Response49
    {
        public string _ref { get; set; }
    }

    public class Errorcode49
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds49
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus49
    {
        public string type { get; set; }
    }

    public class Message49
    {
        public string type { get; set; }
    }

    public class Messagedata49
    {
        public string type { get; set; }
        public Additionalproperties58 additionalProperties { get; set; }
    }

    public class Additionalproperties58
    {
        public string type { get; set; }
    }

    public class Parameter37
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class CommunitycontentLiveAllPartnershiptypeSortPage
    {
        public Get39 get { get; set; }
    }

    public class Get39
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter38[] parameters { get; set; }
        public Responses50 responses { get; set; }
    }

    public class Responses50
    {
        public _20050 _200 { get; set; }
    }

    public class _20050
    {
        public string description { get; set; }
        public Schema50 schema { get; set; }
    }

    public class Schema50
    {
        public Properties50 properties { get; set; }
    }

    public class Properties50
    {
        public Response50 Response { get; set; }
        public Errorcode50 ErrorCode { get; set; }
        public Throttleseconds50 ThrottleSeconds { get; set; }
        public Errorstatus50 ErrorStatus { get; set; }
        public Message50 Message { get; set; }
        public Messagedata50 MessageData { get; set; }
    }

    public class Response50
    {
        public string _ref { get; set; }
    }

    public class Errorcode50
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds50
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus50
    {
        public string type { get; set; }
    }

    public class Message50
    {
        public string type { get; set; }
    }

    public class Messagedata50
    {
        public string type { get; set; }
        public Additionalproperties59 additionalProperties { get; set; }
    }

    public class Additionalproperties59
    {
        public string type { get; set; }
    }

    public class Parameter38
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public bool required { get; set; }
        public string[] _enum { get; set; }
    }

    public class CommunitycontentLiveClanPartnershiptypeSortPage
    {
        public Get40 get { get; set; }
    }

    public class Get40
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter39[] parameters { get; set; }
        public Responses51 responses { get; set; }
    }

    public class Responses51
    {
        public _20051 _200 { get; set; }
    }

    public class _20051
    {
        public string description { get; set; }
        public Schema51 schema { get; set; }
    }

    public class Schema51
    {
        public Properties51 properties { get; set; }
    }

    public class Properties51
    {
        public Response51 Response { get; set; }
        public Errorcode51 ErrorCode { get; set; }
        public Throttleseconds51 ThrottleSeconds { get; set; }
        public Errorstatus51 ErrorStatus { get; set; }
        public Message51 Message { get; set; }
        public Messagedata51 MessageData { get; set; }
    }

    public class Response51
    {
        public string _ref { get; set; }
    }

    public class Errorcode51
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds51
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus51
    {
        public string type { get; set; }
    }

    public class Message51
    {
        public string type { get; set; }
    }

    public class Messagedata51
    {
        public string type { get; set; }
        public Additionalproperties60 additionalProperties { get; set; }
    }

    public class Additionalproperties60
    {
        public string type { get; set; }
    }

    public class Parameter39
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class CommunitycontentLiveFriendsPartnershiptypeSortPage
    {
        public Get41 get { get; set; }
    }

    public class Get41
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter40[] parameters { get; set; }
        public Responses52 responses { get; set; }
    }

    public class Responses52
    {
        public _20052 _200 { get; set; }
    }

    public class _20052
    {
        public string description { get; set; }
        public Schema52 schema { get; set; }
    }

    public class Schema52
    {
        public Properties52 properties { get; set; }
    }

    public class Properties52
    {
        public Response52 Response { get; set; }
        public Errorcode52 ErrorCode { get; set; }
        public Throttleseconds52 ThrottleSeconds { get; set; }
        public Errorstatus52 ErrorStatus { get; set; }
        public Message52 Message { get; set; }
        public Messagedata52 MessageData { get; set; }
    }

    public class Response52
    {
        public string _ref { get; set; }
    }

    public class Errorcode52
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds52
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus52
    {
        public string type { get; set; }
    }

    public class Message52
    {
        public string type { get; set; }
    }

    public class Messagedata52
    {
        public string type { get; set; }
        public Additionalproperties61 additionalProperties { get; set; }
    }

    public class Additionalproperties61
    {
        public string type { get; set; }
    }

    public class Parameter40
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class CommunitycontentLiveFeaturedPartnershiptypeSortPage
    {
        public Get42 get { get; set; }
    }

    public class Get42
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter41[] parameters { get; set; }
        public Responses53 responses { get; set; }
    }

    public class Responses53
    {
        public _20053 _200 { get; set; }
    }

    public class _20053
    {
        public string description { get; set; }
        public Schema53 schema { get; set; }
    }

    public class Schema53
    {
        public Properties53 properties { get; set; }
    }

    public class Properties53
    {
        public Response53 Response { get; set; }
        public Errorcode53 ErrorCode { get; set; }
        public Throttleseconds53 ThrottleSeconds { get; set; }
        public Errorstatus53 ErrorStatus { get; set; }
        public Message53 Message { get; set; }
        public Messagedata53 MessageData { get; set; }
    }

    public class Response53
    {
        public string _ref { get; set; }
    }

    public class Errorcode53
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds53
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus53
    {
        public string type { get; set; }
    }

    public class Message53
    {
        public string type { get; set; }
    }

    public class Messagedata53
    {
        public string type { get; set; }
        public Additionalproperties62 additionalProperties { get; set; }
    }

    public class Additionalproperties62
    {
        public string type { get; set; }
    }

    public class Parameter41
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class CommunitycontentLiveUsersPartnershiptypeMembershiptypeMembershipid
    {
        public Get43 get { get; set; }
    }

    public class Get43
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter42[] parameters { get; set; }
        public Responses54 responses { get; set; }
    }

    public class Responses54
    {
        public _20054 _200 { get; set; }
    }

    public class _20054
    {
        public string description { get; set; }
        public Schema54 schema { get; set; }
    }

    public class Schema54
    {
        public Properties54 properties { get; set; }
    }

    public class Properties54
    {
        public Response54 Response { get; set; }
        public Errorcode54 ErrorCode { get; set; }
        public Throttleseconds54 ThrottleSeconds { get; set; }
        public Errorstatus54 ErrorStatus { get; set; }
        public Message54 Message { get; set; }
        public Messagedata54 MessageData { get; set; }
    }

    public class Response54
    {
        public string _ref { get; set; }
    }

    public class Errorcode54
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds54
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus54
    {
        public string type { get; set; }
    }

    public class Message54
    {
        public string type { get; set; }
    }

    public class Messagedata54
    {
        public string type { get; set; }
        public Additionalproperties63 additionalProperties { get; set; }
    }

    public class Additionalproperties63
    {
        public string type { get; set; }
    }

    public class Parameter42
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class TrendingCategories
    {
        public Get44 get { get; set; }
    }

    public class Get44
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public object[] parameters { get; set; }
        public Responses55 responses { get; set; }
    }

    public class Responses55
    {
        public _20055 _200 { get; set; }
    }

    public class _20055
    {
        public string description { get; set; }
        public Schema55 schema { get; set; }
    }

    public class Schema55
    {
        public Properties55 properties { get; set; }
    }

    public class Properties55
    {
        public Response55 Response { get; set; }
        public Errorcode55 ErrorCode { get; set; }
        public Throttleseconds55 ThrottleSeconds { get; set; }
        public Errorstatus55 ErrorStatus { get; set; }
        public Message55 Message { get; set; }
        public Messagedata55 MessageData { get; set; }
    }

    public class Response55
    {
        public string _ref { get; set; }
    }

    public class Errorcode55
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds55
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus55
    {
        public string type { get; set; }
    }

    public class Message55
    {
        public string type { get; set; }
    }

    public class Messagedata55
    {
        public string type { get; set; }
        public Additionalproperties64 additionalProperties { get; set; }
    }

    public class Additionalproperties64
    {
        public string type { get; set; }
    }

    public class TrendingCategoriesCategoryidPagenumber
    {
        public Get45 get { get; set; }
    }

    public class Get45
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter43[] parameters { get; set; }
        public Responses56 responses { get; set; }
    }

    public class Responses56
    {
        public _20056 _200 { get; set; }
    }

    public class _20056
    {
        public string description { get; set; }
        public Schema56 schema { get; set; }
    }

    public class Schema56
    {
        public Properties56 properties { get; set; }
    }

    public class Properties56
    {
        public Response56 Response { get; set; }
        public Errorcode56 ErrorCode { get; set; }
        public Throttleseconds56 ThrottleSeconds { get; set; }
        public Errorstatus56 ErrorStatus { get; set; }
        public Message56 Message { get; set; }
        public Messagedata56 MessageData { get; set; }
    }

    public class Response56
    {
        public string _ref { get; set; }
    }

    public class Errorcode56
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds56
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus56
    {
        public string type { get; set; }
    }

    public class Message56
    {
        public string type { get; set; }
    }

    public class Messagedata56
    {
        public string type { get; set; }
        public Additionalproperties65 additionalProperties { get; set; }
    }

    public class Additionalproperties65
    {
        public string type { get; set; }
    }

    public class Parameter43
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
    }

    public class TrendingDetailsTrendingentrytypeIdentifier
    {
        public Get46 get { get; set; }
    }

    public class Get46
    {
        public string[] tags { get; set; }
        public string description { get; set; }
        public string operationId { get; set; }
        public Parameter44[] parameters { get; set; }
        public Responses57 responses { get; set; }
    }

    public class Responses57
    {
        public _20057 _200 { get; set; }
    }

    public class _20057
    {
        public string description { get; set; }
        public Schema57 schema { get; set; }
    }

    public class Schema57
    {
        public Properties57 properties { get; set; }
    }

    public class Properties57
    {
        public Response57 Response { get; set; }
        public Errorcode57 ErrorCode { get; set; }
        public Throttleseconds57 ThrottleSeconds { get; set; }
        public Errorstatus57 ErrorStatus { get; set; }
        public Message57 Message { get; set; }
        public Messagedata57 MessageData { get; set; }
    }

    public class Response57
    {
        public string _ref { get; set; }
    }

    public class Errorcode57
    {
        public string _ref { get; set; }
    }

    public class Throttleseconds57
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Errorstatus57
    {
        public string type { get; set; }
    }

    public class Message57
    {
        public string type { get; set; }
    }

    public class Messagedata57
    {
        public string type { get; set; }
        public Additionalproperties66 additionalProperties { get; set; }
    }

    public class Additionalproperties66
    {
        public string type { get; set; }
    }

    public class Parameter44
    {
        public string name { get; set; }
        public string _in { get; set; }
        public string description { get; set; }
        public bool required { get; set; }
        public string type { get; set; }
        public string format { get; set; }
        public string[] _enum { get; set; }
    }

    public class Definitions
    {
        public ApplicationsApplicationscopes ApplicationsApplicationScopes { get; set; }
        public UserGeneraluser UserGeneralUser { get; set; }
        public UserUsertousercontext UserUserToUserContext { get; set; }
        public IgnoresIgnoreresponse IgnoresIgnoreResponse { get; set; }
        public IgnoresIgnorestatus IgnoresIgnoreStatus { get; set; }
        public UserModelsUseralias UserModelsUserAlias { get; set; }
        public ConfigUsertheme ConfigUserTheme { get; set; }
        public Bungiemembershiptype BungieMembershipType { get; set; }
        public UserUsermembershipdata UserUserMembershipData { get; set; }
        public UserUsermembership UserUserMembership { get; set; }
        public UserUserinfocard UserUserInfoCard { get; set; }
        public PartnershipsPublicpartnershipdetail PartnershipsPublicPartnershipDetail { get; set; }
        public PartnershipsPartnershiptype PartnershipsPartnershipType { get; set; }
        public ForumForumtopicscategoryfiltersenum ForumForumTopicsCategoryFiltersEnum { get; set; }
        public ForumForumtopicsquickdateenum ForumForumTopicsQuickDateEnum { get; set; }
        public ForumForumtopicssortenum ForumForumTopicsSortEnum { get; set; }
        public ForumPostresponse ForumPostResponse { get; set; }
        public ForumForummediatype ForumForumMediaType { get; set; }
        public ForumForumpostpopularity ForumForumPostPopularity { get; set; }
        public ForumForumpostcategoryenums ForumForumPostCategoryEnums { get; set; }
        public ForumForumflagsenum ForumForumFlagsEnum { get; set; }
        public QueriesSearchresult QueriesSearchResult { get; set; }
        public QueriesPagedquery QueriesPagedQuery { get; set; }
        public Searchresultofpostresponse SearchResultOfPostResponse { get; set; }
        public ForumPostsearchresponse ForumPostSearchResponse { get; set; }
        public Groupsv2Groupresponse GroupsV2GroupResponse { get; set; }
        public Groupsv2Groupv2 GroupsV2GroupV2 { get; set; }
        public Groupsv2Grouptype GroupsV2GroupType { get; set; }
        public Groupsv2Chatsecuritysetting GroupsV2ChatSecuritySetting { get; set; }
        public Groupsv2Grouphomepage GroupsV2GroupHomepage { get; set; }
        public Groupsv2Membershipoption GroupsV2MembershipOption { get; set; }
        public Groupsv2Grouppostpublicity GroupsV2GroupPostPublicity { get; set; }
        public Groupsv2Groupfeatures GroupsV2GroupFeatures { get; set; }
        public Groupsv2Capabilities GroupsV2Capabilities { get; set; }
        public Groupsv2Hostguidedgamespermissionlevel GroupsV2HostGuidedGamesPermissionLevel { get; set; }
        public Groupsv2Runtimegroupmembertype GroupsV2RuntimeGroupMemberType { get; set; }
        public Groupsv2Groupv2claninfo GroupsV2GroupV2ClanInfo { get; set; }
        public Groupsv2Clanbanner GroupsV2ClanBanner { get; set; }
        public Groupsv2Groupv2claninfoandinvestment GroupsV2GroupV2ClanInfoAndInvestment { get; set; }
        public DestinyDestinyprogression DestinyDestinyProgression { get; set; }
        public DestinyDefinitionsDestinydefinition DestinyDefinitionsDestinyDefinition { get; set; }
        public DestinyDefinitionsDestinyprogressiondefinition DestinyDefinitionsDestinyProgressionDefinition { get; set; }
        public DestinyDefinitionsCommonDestinydisplaypropertiesdefinition DestinyDefinitionsCommonDestinyDisplayPropertiesDefinition { get; set; }
        public DestinyDefinitionsDestinyprogressiondisplaypropertiesdefinition DestinyDefinitionsDestinyProgressionDisplayPropertiesDefinition { get; set; }
        public DestinyDestinyprogressionscope DestinyDestinyProgressionScope { get; set; }
        public DestinyDefinitionsDestinyprogressionstepdefinition DestinyDefinitionsDestinyProgressionStepDefinition { get; set; }
        public DestinyDestinyprogressionstepdisplayeffect DestinyDestinyProgressionStepDisplayEffect { get; set; }
        public DestinyDestinyitemquantity DestinyDestinyItemQuantity { get; set; }
        public DestinyDefinitionsDestinyinventoryitemdefinition DestinyDefinitionsDestinyInventoryItemDefinition { get; set; }
        public DestinyDefinitionsDestinyitemactionblockdefinition DestinyDefinitionsDestinyItemActionBlockDefinition { get; set; }
        public DestinyDefinitionsDestinyitemactionrequireditemdefinition DestinyDefinitionsDestinyItemActionRequiredItemDefinition { get; set; }
        public DestinyDefinitionsDestinyprogressionrewarddefinition DestinyDefinitionsDestinyProgressionRewardDefinition { get; set; }
        public DestinyDefinitionsDestinyprogressionmappingdefinition DestinyDefinitionsDestinyProgressionMappingDefinition { get; set; }
        public DestinyDefinitionsDestinyiteminventoryblockdefinition DestinyDefinitionsDestinyItemInventoryBlockDefinition { get; set; }
        public DestinyTiertype DestinyTierType { get; set; }
        public DestinyDefinitionsDestinyinventorybucketdefinition DestinyDefinitionsDestinyInventoryBucketDefinition { get; set; }
        public DestinyBucketscope DestinyBucketScope { get; set; }
        public DestinyBucketcategory DestinyBucketCategory { get; set; }
        public DestinyItemlocation DestinyItemLocation { get; set; }
        public DestinyDefinitionsItemsDestinyitemtiertypedefinition DestinyDefinitionsItemsDestinyItemTierTypeDefinition { get; set; }
        public DestinyDefinitionsItemsDestinyitemtiertypeinfusionblock DestinyDefinitionsItemsDestinyItemTierTypeInfusionBlock { get; set; }
        public DestinyDefinitionsDestinyitemsetblockdefinition DestinyDefinitionsDestinyItemSetBlockDefinition { get; set; }
        public DestinyDefinitionsDestinyitemsetblockentrydefinition DestinyDefinitionsDestinyItemSetBlockEntryDefinition { get; set; }
        public DestinyDefinitionsDestinyitemstatblockdefinition DestinyDefinitionsDestinyItemStatBlockDefinition { get; set; }
        public DestinyDefinitionsDestinyinventoryitemstatdefinition DestinyDefinitionsDestinyInventoryItemStatDefinition { get; set; }
        public DestinyDefinitionsDestinystatdefinition DestinyDefinitionsDestinyStatDefinition { get; set; }
        public DestinyDestinystataggregationtype DestinyDestinyStatAggregationType { get; set; }
        public DestinyDefinitionsDestinystatgroupdefinition DestinyDefinitionsDestinyStatGroupDefinition { get; set; }
        public DestinyDefinitionsDestinystatdisplaydefinition DestinyDefinitionsDestinyStatDisplayDefinition { get; set; }
        public InterpolationInterpolationpoint InterpolationInterpolationPoint { get; set; }
        public DestinyDefinitionsDestinystatoverridedefinition DestinyDefinitionsDestinyStatOverrideDefinition { get; set; }
        public DestinyDefinitionsDestinyequippingblockdefinition DestinyDefinitionsDestinyEquippingBlockDefinition { get; set; }
        public DestinyEquippingitemblockattributes DestinyEquippingItemBlockAttributes { get; set; }
        public DestinyDefinitionsDestinyequipmentslotdefinition DestinyDefinitionsDestinyEquipmentSlotDefinition { get; set; }
        public DestinyDefinitionsDestinyitemtranslationblockdefinition DestinyDefinitionsDestinyItemTranslationBlockDefinition { get; set; }
        public DestinyDyereference DestinyDyeReference { get; set; }
        public DestinyDefinitionsDestinygearartarrangementreference DestinyDefinitionsDestinyGearArtArrangementReference { get; set; }
        public DestinyDefinitionsDestinyitempreviewblockdefinition DestinyDefinitionsDestinyItemPreviewBlockDefinition { get; set; }
        public DestinyDefinitionsItemsDestinyderiveditemcategorydefinition DestinyDefinitionsItemsDestinyDerivedItemCategoryDefinition { get; set; }
        public DestinyDefinitionsItemsDestinyderiveditemdefinition DestinyDefinitionsItemsDestinyDerivedItemDefinition { get; set; }
        public DestinyDefinitionsDestinyvendordefinition DestinyDefinitionsDestinyVendorDefinition { get; set; }
        public DestinyDefinitionsDestinyvendordisplaypropertiesdefinition DestinyDefinitionsDestinyVendorDisplayPropertiesDefinition { get; set; }
        public DestinyDefinitionsDestinyvendorrequirementdisplayentrydefinition DestinyDefinitionsDestinyVendorRequirementDisplayEntryDefinition { get; set; }
        public DatesDaterange DatesDateRange { get; set; }
        public DestinyDefinitionsDestinyvendoractiondefinition DestinyDefinitionsDestinyVendorActionDefinition { get; set; }
        public DestinyDefinitionsDestinyvendorcategoryentrydefinition DestinyDefinitionsDestinyVendorCategoryEntryDefinition { get; set; }
        public DestinyDefinitionsDestinyvendorcategoryoverlaydefinition DestinyDefinitionsDestinyVendorCategoryOverlayDefinition { get; set; }
        public DestinyDefinitionsDestinydisplaycategorydefinition DestinyDefinitionsDestinyDisplayCategoryDefinition { get; set; }
        public DestinyDefinitionsDestinyvendorinteractiondefinition DestinyDefinitionsDestinyVendorInteractionDefinition { get; set; }
        public DestinyDefinitionsDestinyvendorinteractionreplydefinition DestinyDefinitionsDestinyVendorInteractionReplyDefinition { get; set; }
        public DestinyDestinyvendorinteractionrewardselection DestinyDestinyVendorInteractionRewardSelection { get; set; }
        public DestinyDestinyvendorreplytype DestinyDestinyVendorReplyType { get; set; }
        public DestinyDefinitionsDestinyvendorinteractionsackentrydefinition DestinyDefinitionsDestinyVendorInteractionSackEntryDefinition { get; set; }
        public DestinyDefinitionsDestinyvendorinventoryflyoutdefinition DestinyDefinitionsDestinyVendorInventoryFlyoutDefinition { get; set; }
        public DestinyDefinitionsDestinyvendorinventoryflyoutbucketdefinition DestinyDefinitionsDestinyVendorInventoryFlyoutBucketDefinition { get; set; }
        public DestinyDestinyitemsorttype DestinyDestinyItemSortType { get; set; }
        public DestinyDefinitionsDestinyvendoritemdefinition DestinyDefinitionsDestinyVendorItemDefinition { get; set; }
        public DestinyDestinyvendoritemrefundpolicy DestinyDestinyVendorItemRefundPolicy { get; set; }
        public DestinyDefinitionsDestinyitemcreationentryleveldefinition DestinyDefinitionsDestinyItemCreationEntryLevelDefinition { get; set; }
        public DestinyDefinitionsDestinyvendorsaleitemactionblockdefinition DestinyDefinitionsDestinyVendorSaleItemActionBlockDefinition { get; set; }
        public DestinyDestinygatingscope DestinyDestinyGatingScope { get; set; }
        public DestinyDefinitionsDestinyvendorservicedefinition DestinyDefinitionsDestinyVendorServiceDefinition { get; set; }
        public DestinyDefinitionsDestinyvendoraccepteditemdefinition DestinyDefinitionsDestinyVendorAcceptedItemDefinition { get; set; }
        public DestinyDefinitionsDestinyfactiondefinition DestinyDefinitionsDestinyFactionDefinition { get; set; }
        public DestinyDefinitionsDestinyitemqualityblockdefinition DestinyDefinitionsDestinyItemQualityBlockDefinition { get; set; }
        public DestinyDefinitionsProgressionDestinyprogressionlevelrequirementdefinition DestinyDefinitionsProgressionDestinyProgressionLevelRequirementDefinition { get; set; }
        public InterpolationInterpolationpointfloat InterpolationInterpolationPointFloat { get; set; }
        public DestinyDefinitionsDestinyitemvalueblockdefinition DestinyDefinitionsDestinyItemValueBlockDefinition { get; set; }
        public DestinyDefinitionsDestinyitemsourceblockdefinition DestinyDefinitionsDestinyItemSourceBlockDefinition { get; set; }
        public DestinyDefinitionsSourcesDestinyitemsourcedefinition DestinyDefinitionsSourcesDestinyItemSourceDefinition { get; set; }
        public DestinyDefinitionsDestinyrewardsourcedefinition DestinyDefinitionsDestinyRewardSourceDefinition { get; set; }
        public DestinyDefinitionsDestinyrewardsourcecategory DestinyDefinitionsDestinyRewardSourceCategory { get; set; }
        public DestinyDefinitionsDestinyitemobjectiveblockdefinition DestinyDefinitionsDestinyItemObjectiveBlockDefinition { get; set; }
        public DestinyDefinitionsDestinyobjectivedefinition DestinyDefinitionsDestinyObjectiveDefinition { get; set; }
        public DestinyDestinyunlockvalueuistyle DestinyDestinyUnlockValueUIStyle { get; set; }
        public DestinyDefinitionsDestinyobjectiveperkentrydefinition DestinyDefinitionsDestinyObjectivePerkEntryDefinition { get; set; }
        public DestinyDestinyobjectivegrantstyle DestinyDestinyObjectiveGrantStyle { get; set; }
        public DestinyDefinitionsDestinysandboxperkdefinition DestinyDefinitionsDestinySandboxPerkDefinition { get; set; }
        public DestinyDamagetype DestinyDamageType { get; set; }
        public DestinyDefinitionsDestinytalentnodestepgroups DestinyDefinitionsDestinyTalentNodeStepGroups { get; set; }
        public DestinyDefinitionsDestinytalentnodestepweaponperformances DestinyDefinitionsDestinyTalentNodeStepWeaponPerformances { get; set; }
        public DestinyDefinitionsDestinytalentnodestepimpacteffects DestinyDefinitionsDestinyTalentNodeStepImpactEffects { get; set; }
        public DestinyDefinitionsDestinytalentnodestepguardianattributes DestinyDefinitionsDestinyTalentNodeStepGuardianAttributes { get; set; }
        public DestinyDefinitionsDestinytalentnodesteplightabilities DestinyDefinitionsDestinyTalentNodeStepLightAbilities { get; set; }
        public DestinyDefinitionsDestinytalentnodestepdamagetypes DestinyDefinitionsDestinyTalentNodeStepDamageTypes { get; set; }
        public DestinyDefinitionsDestinyobjectivestatentrydefinition DestinyDefinitionsDestinyObjectiveStatEntryDefinition { get; set; }
        public DestinyDefinitionsDestinyiteminvestmentstatdefinition DestinyDefinitionsDestinyItemInvestmentStatDefinition { get; set; }
        public DestinyDefinitionsDestinylocationdefinition DestinyDefinitionsDestinyLocationDefinition { get; set; }
        public DestinyDefinitionsDestinylocationreleasedefinition DestinyDefinitionsDestinyLocationReleaseDefinition { get; set; }
        public DestinyDestinyactivitynavpointtype DestinyDestinyActivityNavPointType { get; set; }
        public DestinyDefinitionsDestinydestinationdefinition DestinyDefinitionsDestinyDestinationDefinition { get; set; }
        public DestinyDefinitionsDestinyactivitygraphlistentrydefinition DestinyDefinitionsDestinyActivityGraphListEntryDefinition { get; set; }
        public DestinyDefinitionsDirectorDestinyactivitygraphdefinition DestinyDefinitionsDirectorDestinyActivityGraphDefinition { get; set; }
        public DestinyDefinitionsDirectorDestinyactivitygraphnodedefinition DestinyDefinitionsDirectorDestinyActivityGraphNodeDefinition { get; set; }
        public DestinyDefinitionsCommonDestinypositiondefinition DestinyDefinitionsCommonDestinyPositionDefinition { get; set; }
        public DestinyDefinitionsDirectorDestinyactivitygraphnodefeaturingstatedefinition DestinyDefinitionsDirectorDestinyActivityGraphNodeFeaturingStateDefinition { get; set; }
        public DestinyActivitygraphnodehighlighttype DestinyActivityGraphNodeHighlightType { get; set; }
        public DestinyDefinitionsDirectorDestinyactivitygraphnodeactivitydefinition DestinyDefinitionsDirectorDestinyActivityGraphNodeActivityDefinition { get; set; }
        public DestinyDefinitionsDestinyactivitydefinition DestinyDefinitionsDestinyActivityDefinition { get; set; }
        public DestinyDefinitionsDestinyactivityrewarddefinition DestinyDefinitionsDestinyActivityRewardDefinition { get; set; }
        public DestinyDefinitionsDestinyactivitymodifierreferencedefinition DestinyDefinitionsDestinyActivityModifierReferenceDefinition { get; set; }
        public DestinyDefinitionsActivitymodifiersDestinyactivitymodifierdefinition DestinyDefinitionsActivityModifiersDestinyActivityModifierDefinition { get; set; }
        public DestinyDefinitionsDestinyactivitychallengedefinition DestinyDefinitionsDestinyActivityChallengeDefinition { get; set; }
        public DestinyDefinitionsDestinyactivityunlockstringdefinition DestinyDefinitionsDestinyActivityUnlockStringDefinition { get; set; }
        public DestinyDefinitionsDestinyactivitymatchmakingblockdefinition DestinyDefinitionsDestinyActivityMatchmakingBlockDefinition { get; set; }
        public DestinyDefinitionsDestinyactivityguidedblockdefinition DestinyDefinitionsDestinyActivityGuidedBlockDefinition { get; set; }
        public DestinyDefinitionsDestinyplacedefinition DestinyDefinitionsDestinyPlaceDefinition { get; set; }
        public DestinyDefinitionsDestinyactivitytypedefinition DestinyDefinitionsDestinyActivityTypeDefinition { get; set; }
        public DestinyDefinitionsDirectorDestinyactivitygraphartelementdefinition DestinyDefinitionsDirectorDestinyActivityGraphArtElementDefinition { get; set; }
        public DestinyDefinitionsDirectorDestinyactivitygraphconnectiondefinition DestinyDefinitionsDirectorDestinyActivityGraphConnectionDefinition { get; set; }
        public DestinyDefinitionsDirectorDestinyactivitygraphdisplayobjectivedefinition DestinyDefinitionsDirectorDestinyActivityGraphDisplayObjectiveDefinition { get; set; }
        public DestinyDefinitionsDirectorDestinyactivitygraphdisplayprogressiondefinition DestinyDefinitionsDirectorDestinyActivityGraphDisplayProgressionDefinition { get; set; }
        public DestinyDefinitionsDirectorDestinylinkedgraphdefinition DestinyDefinitionsDirectorDestinyLinkedGraphDefinition { get; set; }
        public DestinyDefinitionsDestinyunlockexpressiondefinition DestinyDefinitionsDestinyUnlockExpressionDefinition { get; set; }
        public DestinyDefinitionsDirectorDestinylinkedgraphentrydefinition DestinyDefinitionsDirectorDestinyLinkedGraphEntryDefinition { get; set; }
        public DestinyDefinitionsDestinydestinationbubblesettingdefinition DestinyDefinitionsDestinyDestinationBubbleSettingDefinition { get; set; }
        public DestinyDefinitionsDestinybubbledefinition DestinyDefinitionsDestinyBubbleDefinition { get; set; }
        public DestinyDefinitionsItemsDestinyitemplugdefinition DestinyDefinitionsItemsDestinyItemPlugDefinition { get; set; }
        public DestinyDefinitionsItemsDestinyplugruledefinition DestinyDefinitionsItemsDestinyPlugRuleDefinition { get; set; }
        public DestinyDefinitionsDestinymaterialrequirementsetdefinition DestinyDefinitionsDestinyMaterialRequirementSetDefinition { get; set; }
        public DestinyDefinitionsDestinymaterialrequirement DestinyDefinitionsDestinyMaterialRequirement { get; set; }
        public DestinyDefinitionsDestinyitemgearsetblockdefinition DestinyDefinitionsDestinyItemGearsetBlockDefinition { get; set; }
        public DestinyDefinitionsDestinyitemsackblockdefinition DestinyDefinitionsDestinyItemSackBlockDefinition { get; set; }
        public DestinyDefinitionsDestinyitemsocketblockdefinition DestinyDefinitionsDestinyItemSocketBlockDefinition { get; set; }
        public DestinyDefinitionsDestinyitemsocketentrydefinition DestinyDefinitionsDestinyItemSocketEntryDefinition { get; set; }
        public DestinyDefinitionsDestinyitemsocketentryplugitemdefinition DestinyDefinitionsDestinyItemSocketEntryPlugItemDefinition { get; set; }
        public DestinyDefinitionsSocketsDestinysockettypedefinition DestinyDefinitionsSocketsDestinySocketTypeDefinition { get; set; }
        public DestinyDefinitionsSocketsDestinyinsertplugactiondefinition DestinyDefinitionsSocketsDestinyInsertPlugActionDefinition { get; set; }
        public DestinyDefinitionsSocketsDestinyplugwhitelistentrydefinition DestinyDefinitionsSocketsDestinyPlugWhitelistEntryDefinition { get; set; }
        public DestinyDestinysocketvisibility DestinyDestinySocketVisibility { get; set; }
        public DestinyDefinitionsDestinyitemsocketcategorydefinition DestinyDefinitionsDestinyItemSocketCategoryDefinition { get; set; }
        public DestinyDefinitionsDestinyitemsummaryblockdefinition DestinyDefinitionsDestinyItemSummaryBlockDefinition { get; set; }
        public DestinyDefinitionsDestinyitemtalentgridblockdefinition DestinyDefinitionsDestinyItemTalentGridBlockDefinition { get; set; }
        public DestinyDefinitionsDestinytalentgriddefinition DestinyDefinitionsDestinyTalentGridDefinition { get; set; }
        public DestinyDefinitionsDestinytalentnodedefinition DestinyDefinitionsDestinyTalentNodeDefinition { get; set; }
        public DestinyDefinitionsDestinynodeactivationrequirement DestinyDefinitionsDestinyNodeActivationRequirement { get; set; }
        public DestinyDefinitionsDestinynodestepdefinition DestinyDefinitionsDestinyNodeStepDefinition { get; set; }
        public DestinyDefinitionsDestinynodesocketreplaceresponse DestinyDefinitionsDestinyNodeSocketReplaceResponse { get; set; }
        public DestinyDefinitionsDestinydamagetypedefinition DestinyDefinitionsDestinyDamageTypeDefinition { get; set; }
        public DestinyDefinitionsLoreDestinyloredefinition DestinyDefinitionsLoreDestinyLoreDefinition { get; set; }
        public DestinyDefinitionsDestinytalentnodeexclusivesetdefinition DestinyDefinitionsDestinyTalentNodeExclusiveSetDefinition { get; set; }
        public DestinyDefinitionsDestinytalentexclusivegroup DestinyDefinitionsDestinyTalentExclusiveGroup { get; set; }
        public DestinyDefinitionsDestinytalentnodecategory DestinyDefinitionsDestinyTalentNodeCategory { get; set; }
        public DestinyDefinitionsDestinyitemperkentrydefinition DestinyDefinitionsDestinyItemPerkEntryDefinition { get; set; }
        public DestinyDefinitionsAnimationsDestinyanimationreference DestinyDefinitionsAnimationsDestinyAnimationReference { get; set; }
        public LinksHyperlinkreference LinksHyperlinkReference { get; set; }
        public DestinySpecialitemtype DestinySpecialItemType { get; set; }
        public DestinyDestinyitemtype DestinyDestinyItemType { get; set; }
        public DestinyDestinyitemsubtype DestinyDestinyItemSubType { get; set; }
        public DestinyDestinyclass DestinyDestinyClass { get; set; }
        public DestinyDefinitionsDestinyitemcategorydefinition DestinyDefinitionsDestinyItemCategoryDefinition { get; set; }
        public Groupsv2Groupuserbase GroupsV2GroupUserBase { get; set; }
        public Groupsv2Groupmember GroupsV2GroupMember { get; set; }
        public Groupsv2Groupalliancestatus GroupsV2GroupAllianceStatus { get; set; }
        public Groupsv2Grouppotentialmember GroupsV2GroupPotentialMember { get; set; }
        public Groupsv2Grouppotentialmemberstatus GroupsV2GroupPotentialMemberStatus { get; set; }
        public TagsModelsContractsTagresponse TagsModelsContractsTagResponse { get; set; }
        public ForumPollresponse ForumPollResponse { get; set; }
        public ForumPollresult ForumPollResult { get; set; }
        public ForumForumrecruitmentdetail ForumForumRecruitmentDetail { get; set; }
        public ForumForumrecruitmentintensitylabel ForumForumRecruitmentIntensityLabel { get; set; }
        public ForumForumrecruitmenttonelabel ForumForumRecruitmentToneLabel { get; set; }
        public ForumForumpostsortenum ForumForumPostSortEnum { get; set; }
        public MessagesResponsesSavemessageresult MessagesResponsesSaveMessageResult { get; set; }
        public DestinyConfigDestinymanifest DestinyConfigDestinyManifest { get; set; }
        public DestinyConfigGearassetdatabasedefinition DestinyConfigGearAssetDataBaseDefinition { get; set; }
        public DestinyDestinycomponenttype DestinyDestinyComponentType { get; set; }
        public DestinyResponsesDestinyprofileresponse DestinyResponsesDestinyProfileResponse { get; set; }
        public DestinyEntitiesProfilesDestinyvendorreceiptscomponent DestinyEntitiesProfilesDestinyVendorReceiptsComponent { get; set; }
        public DestinyVendorsDestinyvendorreceipt DestinyVendorsDestinyVendorReceipt { get; set; }
        public ComponentsComponentresponse ComponentsComponentResponse { get; set; }
        public ComponentsComponentprivacysetting ComponentsComponentPrivacySetting { get; set; }
        public Singlecomponentresponseofdestinyvendorreceiptscomponent SingleComponentResponseOfDestinyVendorReceiptsComponent { get; set; }
        public DestinyEntitiesInventoryDestinyinventorycomponent DestinyEntitiesInventoryDestinyInventoryComponent { get; set; }
        public DestinyEntitiesItemsDestinyitemcomponent DestinyEntitiesItemsDestinyItemComponent { get; set; }
        public DestinyItembindstatus DestinyItemBindStatus { get; set; }
        public DestinyTransferstatuses DestinyTransferStatuses { get; set; }
        public DestinyItemstate DestinyItemState { get; set; }
        public Singlecomponentresponseofdestinyinventorycomponent SingleComponentResponseOfDestinyInventoryComponent { get; set; }
        public DestinyEntitiesProfilesDestinyprofilecomponent DestinyEntitiesProfilesDestinyProfileComponent { get; set; }
        public DestinyDestinygameversions DestinyDestinyGameVersions { get; set; }
        public Singlecomponentresponseofdestinyprofilecomponent SingleComponentResponseOfDestinyProfileComponent { get; set; }
        public DestinyComponentsKiosksDestinykioskscomponent DestinyComponentsKiosksDestinyKiosksComponent { get; set; }
        public DestinyComponentsKiosksDestinykioskitem DestinyComponentsKiosksDestinyKioskItem { get; set; }
        public Singlecomponentresponseofdestinykioskscomponent SingleComponentResponseOfDestinyKiosksComponent { get; set; }
        public DestinyEntitiesCharactersDestinycharactercomponent DestinyEntitiesCharactersDestinyCharacterComponent { get; set; }
        public DestinyDestinyrace DestinyDestinyRace { get; set; }
        public DestinyDestinygender DestinyDestinyGender { get; set; }
        public DestinyDefinitionsDestinyracedefinition DestinyDefinitionsDestinyRaceDefinition { get; set; }
        public DestinyDefinitionsDestinygenderdefinition DestinyDefinitionsDestinyGenderDefinition { get; set; }
        public DestinyDefinitionsDestinyclassdefinition DestinyDefinitionsDestinyClassDefinition { get; set; }
        public Dictionarycomponentresponseofint64anddestinycharactercomponent DictionaryComponentResponseOfint64AndDestinyCharacterComponent { get; set; }
        public Dictionarycomponentresponseofint64anddestinyinventorycomponent DictionaryComponentResponseOfint64AndDestinyInventoryComponent { get; set; }
        public DestinyEntitiesCharactersDestinycharacterprogressioncomponent DestinyEntitiesCharactersDestinyCharacterProgressionComponent { get; set; }
        public DestinyProgressionDestinyfactionprogression DestinyProgressionDestinyFactionProgression { get; set; }
        public DestinyMilestonesDestinymilestone DestinyMilestonesDestinyMilestone { get; set; }
        public DestinyMilestonesDestinymilestonequest DestinyMilestonesDestinyMilestoneQuest { get; set; }
        public DestinyQuestsDestinyqueststatus DestinyQuestsDestinyQuestStatus { get; set; }
        public DestinyQuestsDestinyobjectiveprogress DestinyQuestsDestinyObjectiveProgress { get; set; }
        public DestinyMilestonesDestinymilestoneactivity DestinyMilestonesDestinyMilestoneActivity { get; set; }
        public DestinyMilestonesDestinymilestoneactivityvariant DestinyMilestonesDestinyMilestoneActivityVariant { get; set; }
        public DestinyMilestonesDestinymilestoneactivitycompletionstatus DestinyMilestonesDestinyMilestoneActivityCompletionStatus { get; set; }
        public DestinyMilestonesDestinymilestoneactivityphase DestinyMilestonesDestinyMilestoneActivityPhase { get; set; }
        public DestinyChallengesDestinychallengestatus DestinyChallengesDestinyChallengeStatus { get; set; }
        public DestinyMilestonesDestinymilestonerewardcategory DestinyMilestonesDestinyMilestoneRewardCategory { get; set; }
        public DestinyMilestonesDestinymilestonerewardentry DestinyMilestonesDestinyMilestoneRewardEntry { get; set; }
        public DestinyDefinitionsMilestonesDestinymilestonedefinition DestinyDefinitionsMilestonesDestinyMilestoneDefinition { get; set; }
        public DestinyDefinitionsMilestonesDestinymilestonetype DestinyDefinitionsMilestonesDestinyMilestoneType { get; set; }
        public DestinyDefinitionsMilestonesDestinymilestonequestdefinition DestinyDefinitionsMilestonesDestinyMilestoneQuestDefinition { get; set; }
        public DestinyDefinitionsMilestonesDestinymilestonequestrewardsdefinition DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardsDefinition { get; set; }
        public DestinyDefinitionsMilestonesDestinymilestonequestrewarditem DestinyDefinitionsMilestonesDestinyMilestoneQuestRewardItem { get; set; }
        public DestinyDefinitionsMilestonesDestinymilestoneactivitydefinition DestinyDefinitionsMilestonesDestinyMilestoneActivityDefinition { get; set; }
        public DestinyDefinitionsMilestonesDestinymilestoneactivityvariantdefinition DestinyDefinitionsMilestonesDestinyMilestoneActivityVariantDefinition { get; set; }
        public DestinyDefinitionsMilestonesDestinymilestonerewardcategorydefinition DestinyDefinitionsMilestonesDestinyMilestoneRewardCategoryDefinition { get; set; }
        public DestinyDefinitionsMilestonesDestinymilestonerewardentrydefinition DestinyDefinitionsMilestonesDestinyMilestoneRewardEntryDefinition { get; set; }
        public DestinyDefinitionsMilestonesDestinymilestonevendordefinition DestinyDefinitionsMilestonesDestinyMilestoneVendorDefinition { get; set; }
        public DestinyDefinitionsMilestonesDestinymilestonevaluedefinition DestinyDefinitionsMilestonesDestinyMilestoneValueDefinition { get; set; }
        public Dictionarycomponentresponseofint64anddestinycharacterprogressioncomponent DictionaryComponentResponseOfint64AndDestinyCharacterProgressionComponent { get; set; }
        public DestinyEntitiesCharactersDestinycharacterrendercomponent DestinyEntitiesCharactersDestinyCharacterRenderComponent { get; set; }
        public DestinyCharacterDestinycharactercustomization DestinyCharacterDestinyCharacterCustomization { get; set; }
        public DestinyCharacterDestinycharacterpeerview DestinyCharacterDestinyCharacterPeerView { get; set; }
        public DestinyCharacterDestinyitempeerview DestinyCharacterDestinyItemPeerView { get; set; }
        public Dictionarycomponentresponseofint64anddestinycharacterrendercomponent DictionaryComponentResponseOfint64AndDestinyCharacterRenderComponent { get; set; }
        public DestinyEntitiesCharactersDestinycharacteractivitiescomponent DestinyEntitiesCharactersDestinyCharacterActivitiesComponent { get; set; }
        public DestinyDestinyactivity DestinyDestinyActivity { get; set; }
        public DestinyDestinyactivitydifficultytier DestinyDestinyActivityDifficultyTier { get; set; }
        public DestinyDefinitionsDestinyactivitymodedefinition DestinyDefinitionsDestinyActivityModeDefinition { get; set; }
        public DestinyHistoricalstatsDefinitionsDestinyactivitymodetype DestinyHistoricalStatsDefinitionsDestinyActivityModeType { get; set; }
        public DestinyDestinyactivitymodecategory DestinyDestinyActivityModeCategory { get; set; }
        public Dictionarycomponentresponseofint64anddestinycharacteractivitiescomponent DictionaryComponentResponseOfint64AndDestinyCharacterActivitiesComponent { get; set; }
        public Dictionarycomponentresponseofint64anddestinykioskscomponent DictionaryComponentResponseOfint64AndDestinyKiosksComponent { get; set; }
        public Destinyitemcomponentsetofint64 DestinyItemComponentSetOfint64 { get; set; }
        public DestinyEntitiesItemsDestinyiteminstancecomponent DestinyEntitiesItemsDestinyItemInstanceComponent { get; set; }
        public DestinyDestinystat DestinyDestinyStat { get; set; }
        public DestinyEquipfailurereason DestinyEquipFailureReason { get; set; }
        public DestinyDefinitionsDestinyunlockdefinition DestinyDefinitionsDestinyUnlockDefinition { get; set; }
        public Dictionarycomponentresponseofint64anddestinyiteminstancecomponent DictionaryComponentResponseOfint64AndDestinyItemInstanceComponent { get; set; }
        public DestinyEntitiesItemsDestinyitemobjectivescomponent DestinyEntitiesItemsDestinyItemObjectivesComponent { get; set; }
        public Dictionarycomponentresponseofint64anddestinyitemobjectivescomponent DictionaryComponentResponseOfint64AndDestinyItemObjectivesComponent { get; set; }
        public DestinyEntitiesItemsDestinyitemperkscomponent DestinyEntitiesItemsDestinyItemPerksComponent { get; set; }
        public DestinyPerksDestinyperkreference DestinyPerksDestinyPerkReference { get; set; }
        public Dictionarycomponentresponseofint64anddestinyitemperkscomponent DictionaryComponentResponseOfint64AndDestinyItemPerksComponent { get; set; }
        public DestinyEntitiesItemsDestinyitemrendercomponent DestinyEntitiesItemsDestinyItemRenderComponent { get; set; }
        public Dictionarycomponentresponseofint64anddestinyitemrendercomponent DictionaryComponentResponseOfint64AndDestinyItemRenderComponent { get; set; }
        public DestinyEntitiesItemsDestinyitemstatscomponent DestinyEntitiesItemsDestinyItemStatsComponent { get; set; }
        public Dictionarycomponentresponseofint64anddestinyitemstatscomponent DictionaryComponentResponseOfint64AndDestinyItemStatsComponent { get; set; }
        public DestinyEntitiesItemsDestinyitemsocketscomponent DestinyEntitiesItemsDestinyItemSocketsComponent { get; set; }
        public DestinyEntitiesItemsDestinyitemsocketstate DestinyEntitiesItemsDestinyItemSocketState { get; set; }
        public Dictionarycomponentresponseofint64anddestinyitemsocketscomponent DictionaryComponentResponseOfint64AndDestinyItemSocketsComponent { get; set; }
        public DestinyEntitiesItemsDestinyitemtalentgridcomponent DestinyEntitiesItemsDestinyItemTalentGridComponent { get; set; }
        public DestinyDestinytalentnode DestinyDestinyTalentNode { get; set; }
        public DestinyDestinytalentnodestate DestinyDestinyTalentNodeState { get; set; }
        public DestinyDestinytalentnodestatblock DestinyDestinyTalentNodeStatBlock { get; set; }
        public Dictionarycomponentresponseofint64anddestinyitemtalentgridcomponent DictionaryComponentResponseOfint64AndDestinyItemTalentGridComponent { get; set; }
        public DestinyComponentsItemsDestinyitemplugcomponent DestinyComponentsItemsDestinyItemPlugComponent { get; set; }
        public Dictionarycomponentresponseofuint32anddestinyitemplugcomponent DictionaryComponentResponseOfuint32AndDestinyItemPlugComponent { get; set; }
        public DestinyResponsesDestinycharacterresponse DestinyResponsesDestinyCharacterResponse { get; set; }
        public Singlecomponentresponseofdestinycharactercomponent SingleComponentResponseOfDestinyCharacterComponent { get; set; }
        public Singlecomponentresponseofdestinycharacterprogressioncomponent SingleComponentResponseOfDestinyCharacterProgressionComponent { get; set; }
        public Singlecomponentresponseofdestinycharacterrendercomponent SingleComponentResponseOfDestinyCharacterRenderComponent { get; set; }
        public Singlecomponentresponseofdestinycharacteractivitiescomponent SingleComponentResponseOfDestinyCharacterActivitiesComponent { get; set; }
        public DestinyResponsesDestinyitemresponse DestinyResponsesDestinyItemResponse { get; set; }
        public Singlecomponentresponseofdestinyitemcomponent SingleComponentResponseOfDestinyItemComponent { get; set; }
        public Singlecomponentresponseofdestinyiteminstancecomponent SingleComponentResponseOfDestinyItemInstanceComponent { get; set; }
        public Singlecomponentresponseofdestinyitemobjectivescomponent SingleComponentResponseOfDestinyItemObjectivesComponent { get; set; }
        public Singlecomponentresponseofdestinyitemperkscomponent SingleComponentResponseOfDestinyItemPerksComponent { get; set; }
        public Singlecomponentresponseofdestinyitemrendercomponent SingleComponentResponseOfDestinyItemRenderComponent { get; set; }
        public Singlecomponentresponseofdestinyitemstatscomponent SingleComponentResponseOfDestinyItemStatsComponent { get; set; }
        public Singlecomponentresponseofdestinyitemtalentgridcomponent SingleComponentResponseOfDestinyItemTalentGridComponent { get; set; }
        public Singlecomponentresponseofdestinyitemsocketscomponent SingleComponentResponseOfDestinyItemSocketsComponent { get; set; }
        public DestinyResponsesDestinyvendorresponse DestinyResponsesDestinyVendorResponse { get; set; }
        public DestinyEntitiesVendorsDestinyvendorcomponent DestinyEntitiesVendorsDestinyVendorComponent { get; set; }
        public UserAckstate UserAckState { get; set; }
        public Singlecomponentresponseofdestinyvendorcomponent SingleComponentResponseOfDestinyVendorComponent { get; set; }
        public DestinyEntitiesVendorsDestinyvendorcategoriescomponent DestinyEntitiesVendorsDestinyVendorCategoriesComponent { get; set; }
        public DestinyEntitiesVendorsDestinyvendorcategory DestinyEntitiesVendorsDestinyVendorCategory { get; set; }
        public Singlecomponentresponseofdestinyvendorcategoriescomponent SingleComponentResponseOfDestinyVendorCategoriesComponent { get; set; }
        public DestinyEntitiesVendorsDestinyvendorsaleitemcomponent DestinyEntitiesVendorsDestinyVendorSaleItemComponent { get; set; }
        public DestinyVendoritemstatus DestinyVendorItemStatus { get; set; }
        public DestinyDestinyunlockstatus DestinyDestinyUnlockStatus { get; set; }
        public Dictionarycomponentresponseofint32anddestinyvendorsaleitemcomponent DictionaryComponentResponseOfint32AndDestinyVendorSaleItemComponent { get; set; }
        public Destinyitemcomponentsetofint32 DestinyItemComponentSetOfint32 { get; set; }
        public Dictionarycomponentresponseofint32anddestinyiteminstancecomponent DictionaryComponentResponseOfint32AndDestinyItemInstanceComponent { get; set; }
        public Dictionarycomponentresponseofint32anddestinyitemobjectivescomponent DictionaryComponentResponseOfint32AndDestinyItemObjectivesComponent { get; set; }
        public Dictionarycomponentresponseofint32anddestinyitemperkscomponent DictionaryComponentResponseOfint32AndDestinyItemPerksComponent { get; set; }
        public Dictionarycomponentresponseofint32anddestinyitemrendercomponent DictionaryComponentResponseOfint32AndDestinyItemRenderComponent { get; set; }
        public Dictionarycomponentresponseofint32anddestinyitemstatscomponent DictionaryComponentResponseOfint32AndDestinyItemStatsComponent { get; set; }
        public Dictionarycomponentresponseofint32anddestinyitemsocketscomponent DictionaryComponentResponseOfint32AndDestinyItemSocketsComponent { get; set; }
        public Dictionarycomponentresponseofint32anddestinyitemtalentgridcomponent DictionaryComponentResponseOfint32AndDestinyItemTalentGridComponent { get; set; }
        public DestinyRequestsActionsDestinyactionrequest DestinyRequestsActionsDestinyActionRequest { get; set; }
        public DestinyRequestsActionsDestinycharacteractionrequest DestinyRequestsActionsDestinyCharacterActionRequest { get; set; }
        public DestinyRequestsActionsDestinyitemactionrequest DestinyRequestsActionsDestinyItemActionRequest { get; set; }
        public DestinyRequestsDestinyitemtransferrequest DestinyRequestsDestinyItemTransferRequest { get; set; }
        public DestinyDestinyequipitemresults DestinyDestinyEquipItemResults { get; set; }
        public DestinyDestinyequipitemresult DestinyDestinyEquipItemResult { get; set; }
        public ExceptionsPlatformerrorcodes ExceptionsPlatformErrorCodes { get; set; }
        public DestinyRequestsActionsDestinyitemsetactionrequest DestinyRequestsActionsDestinyItemSetActionRequest { get; set; }
        public DestinyRequestsActionsDestinyitemstaterequest DestinyRequestsActionsDestinyItemStateRequest { get; set; }
        public DestinyHistoricalstatsDestinypostgamecarnagereportdata DestinyHistoricalStatsDestinyPostGameCarnageReportData { get; set; }
        public DestinyHistoricalstatsDestinyhistoricalstatsactivity DestinyHistoricalStatsDestinyHistoricalStatsActivity { get; set; }
        public DestinyHistoricalstatsDestinypostgamecarnagereportentry DestinyHistoricalStatsDestinyPostGameCarnageReportEntry { get; set; }
        public DestinyHistoricalstatsDestinyhistoricalstatsvalue DestinyHistoricalStatsDestinyHistoricalStatsValue { get; set; }
        public DestinyHistoricalstatsDestinyhistoricalstatsvaluepair DestinyHistoricalStatsDestinyHistoricalStatsValuePair { get; set; }
        public DestinyHistoricalstatsDestinyplayer DestinyHistoricalStatsDestinyPlayer { get; set; }
        public DestinyHistoricalstatsDestinypostgamecarnagereportextendeddata DestinyHistoricalStatsDestinyPostGameCarnageReportExtendedData { get; set; }
        public DestinyHistoricalstatsDestinyhistoricalweaponstats DestinyHistoricalStatsDestinyHistoricalWeaponStats { get; set; }
        public DestinyHistoricalstatsDestinypostgamecarnagereportteamentry DestinyHistoricalStatsDestinyPostGameCarnageReportTeamEntry { get; set; }
        public DestinyHistoricalstatsDefinitionsDestinyhistoricalstatsdefinition DestinyHistoricalStatsDefinitionsDestinyHistoricalStatsDefinition { get; set; }
        public DestinyHistoricalstatsDefinitionsDestinystatsgrouptype DestinyHistoricalStatsDefinitionsDestinyStatsGroupType { get; set; }
        public DestinyHistoricalstatsDefinitionsPeriodtype DestinyHistoricalStatsDefinitionsPeriodType { get; set; }
        public DestinyHistoricalstatsDefinitionsDestinystatscategorytype DestinyHistoricalStatsDefinitionsDestinyStatsCategoryType { get; set; }
        public DestinyHistoricalstatsDefinitionsUnittype DestinyHistoricalStatsDefinitionsUnitType { get; set; }
        public DestinyHistoricalstatsDefinitionsDestinystatsmergemethod DestinyHistoricalStatsDefinitionsDestinyStatsMergeMethod { get; set; }
        public DestinyHistoricalstatsDestinyleaderboard DestinyHistoricalStatsDestinyLeaderboard { get; set; }
        public DestinyHistoricalstatsDestinyleaderboardentry DestinyHistoricalStatsDestinyLeaderboardEntry { get; set; }
        public DestinyHistoricalstatsDestinyleaderboardresults DestinyHistoricalStatsDestinyLeaderboardResults { get; set; }
        public DestinyHistoricalstatsDestinyclanaggregatestat DestinyHistoricalStatsDestinyClanAggregateStat { get; set; }
        public DestinyDefinitionsDestinyentitysearchresult DestinyDefinitionsDestinyEntitySearchResult { get; set; }
        public DestinyDefinitionsDestinyentitysearchresultitem DestinyDefinitionsDestinyEntitySearchResultItem { get; set; }
        public Searchresultofdestinyentitysearchresultitem SearchResultOfDestinyEntitySearchResultItem { get; set; }
        public DestinyHistoricalstatsDestinyhistoricalstatsbyperiod DestinyHistoricalStatsDestinyHistoricalStatsByPeriod { get; set; }
        public DestinyHistoricalstatsDestinyhistoricalstatsperiodgroup DestinyHistoricalStatsDestinyHistoricalStatsPeriodGroup { get; set; }
        public DestinyHistoricalstatsDestinyhistoricalstatsresults DestinyHistoricalStatsDestinyHistoricalStatsResults { get; set; }
        public DestinyHistoricalstatsDestinyhistoricalstatsaccountresult DestinyHistoricalStatsDestinyHistoricalStatsAccountResult { get; set; }
        public DestinyHistoricalstatsDestinyhistoricalstatswithmerged DestinyHistoricalStatsDestinyHistoricalStatsWithMerged { get; set; }
        public DestinyHistoricalstatsDestinyhistoricalstatspercharacter DestinyHistoricalStatsDestinyHistoricalStatsPerCharacter { get; set; }
        public DestinyHistoricalstatsDestinyactivityhistoryresults DestinyHistoricalStatsDestinyActivityHistoryResults { get; set; }
        public DestinyHistoricalstatsDestinyhistoricalweaponstatsdata DestinyHistoricalStatsDestinyHistoricalWeaponStatsData { get; set; }
        public DestinyHistoricalstatsDestinyaggregateactivityresults DestinyHistoricalStatsDestinyAggregateActivityResults { get; set; }
        public DestinyHistoricalstatsDestinyaggregateactivitystats DestinyHistoricalStatsDestinyAggregateActivityStats { get; set; }
        public DestinyMilestonesDestinymilestonecontent DestinyMilestonesDestinyMilestoneContent { get; set; }
        public DestinyMilestonesDestinymilestonecontentitemcategory DestinyMilestonesDestinyMilestoneContentItemCategory { get; set; }
        public DestinyMilestonesDestinypublicmilestone DestinyMilestonesDestinyPublicMilestone { get; set; }
        public DestinyMilestonesDestinypublicmilestonequest DestinyMilestonesDestinyPublicMilestoneQuest { get; set; }
        public DestinyMilestonesDestinypublicmilestoneactivity DestinyMilestonesDestinyPublicMilestoneActivity { get; set; }
        public DestinyMilestonesDestinypublicmilestoneactivityvariant DestinyMilestonesDestinyPublicMilestoneActivityVariant { get; set; }
        public DestinyMilestonesDestinypublicmilestonechallenge DestinyMilestonesDestinyPublicMilestoneChallenge { get; set; }
        public ForumCommunitycontentsortmode ForumCommunityContentSortMode { get; set; }
        public CommunityCommunitystatussort CommunityCommunityStatusSort { get; set; }
        public CommunityCommunitylivestatus CommunityCommunityLiveStatus { get; set; }
        public Searchresultofcommunitylivestatus SearchResultOfCommunityLiveStatus { get; set; }
        public TrendingTrendingcategories TrendingTrendingCategories { get; set; }
        public TrendingTrendingcategory TrendingTrendingCategory { get; set; }
        public TrendingTrendingentry TrendingTrendingEntry { get; set; }
        public TrendingTrendingentrytype TrendingTrendingEntryType { get; set; }
        public Searchresultoftrendingentry SearchResultOfTrendingEntry { get; set; }
        public TrendingTrendingdetail TrendingTrendingDetail { get; set; }
        public TrendingTrendingentrynews TrendingTrendingEntryNews { get; set; }
        public ContentContentitempubliccontract ContentContentItemPublicContract { get; set; }
        public ContentContentrepresentation ContentContentRepresentation { get; set; }
        public ContentCommentsummary ContentCommentSummary { get; set; }
        public TrendingTrendingentrysupportarticle TrendingTrendingEntrySupportArticle { get; set; }
        public TrendingTrendingentrydestinyitem TrendingTrendingEntryDestinyItem { get; set; }
        public TrendingTrendingentrydestinyactivity TrendingTrendingEntryDestinyActivity { get; set; }
        public DestinyActivitiesDestinypublicactivitystatus DestinyActivitiesDestinyPublicActivityStatus { get; set; }
        public TrendingTrendingentrydestinyritual TrendingTrendingEntryDestinyRitual { get; set; }
        public TrendingTrendingentrycommunitycreation TrendingTrendingEntryCommunityCreation { get; set; }
        public TrendingTrendingentrycommunitystream TrendingTrendingEntryCommunityStream { get; set; }
    }

    public class ApplicationsApplicationscopes
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues[] xenumvalues { get; set; }
    }

    public class XEnumValues
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
    }

    public class UserGeneraluser
    {
        public Properties58 properties { get; set; }
    }

    public class Properties58
    {
        public Membershipid membershipId { get; set; }
        public Uniquename uniqueName { get; set; }
        public Normalizedname normalizedName { get; set; }
        public Displayname displayName { get; set; }
        public Profilepicture profilePicture { get; set; }
        public Profiletheme profileTheme { get; set; }
        public Usertitle userTitle { get; set; }
        public Successmessageflags successMessageFlags { get; set; }
        public Isdeleted isDeleted { get; set; }
        public About about { get; set; }
        public Firstaccess firstAccess { get; set; }
        public Lastupdate lastUpdate { get; set; }
        public Legacyportaluid legacyPortalUID { get; set; }
        public Context context { get; set; }
        public Psndisplayname psnDisplayName { get; set; }
        public Xboxdisplayname xboxDisplayName { get; set; }
        public Fbdisplayname fbDisplayName { get; set; }
        public Showactivity showActivity { get; set; }
        public Locale locale { get; set; }
        public Localeinheritdefault localeInheritDefault { get; set; }
        public Lastbanreportid lastBanReportId { get; set; }
        public Showgroupmessaging showGroupMessaging { get; set; }
        public Profilepicturepath profilePicturePath { get; set; }
        public Profilepicturewidepath profilePictureWidePath { get; set; }
        public Profilethemename profileThemeName { get; set; }
        public Usertitledisplay userTitleDisplay { get; set; }
        public Statustext statusText { get; set; }
        public Statusdate statusDate { get; set; }
        public Profilebanexpire profileBanExpire { get; set; }
        public Blizzarddisplayname blizzardDisplayName { get; set; }
    }

    public class Membershipid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Uniquename
    {
        public string type { get; set; }
    }

    public class Normalizedname
    {
        public string type { get; set; }
    }

    public class Displayname
    {
        public string type { get; set; }
    }

    public class Profilepicture
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Profiletheme
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Usertitle
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Successmessageflags
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Isdeleted
    {
        public string type { get; set; }
    }

    public class About
    {
        public string type { get; set; }
    }

    public class Firstaccess
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Lastupdate
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Legacyportaluid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Context
    {
        public string _ref { get; set; }
    }

    public class Psndisplayname
    {
        public string type { get; set; }
    }

    public class Xboxdisplayname
    {
        public string type { get; set; }
    }

    public class Fbdisplayname
    {
        public string type { get; set; }
    }

    public class Showactivity
    {
        public string type { get; set; }
    }

    public class Locale
    {
        public string type { get; set; }
    }

    public class Localeinheritdefault
    {
        public string type { get; set; }
    }

    public class Lastbanreportid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Showgroupmessaging
    {
        public string type { get; set; }
    }

    public class Profilepicturepath
    {
        public string type { get; set; }
    }

    public class Profilepicturewidepath
    {
        public string type { get; set; }
    }

    public class Profilethemename
    {
        public string type { get; set; }
    }

    public class Usertitledisplay
    {
        public string type { get; set; }
    }

    public class Statustext
    {
        public string type { get; set; }
    }

    public class Statusdate
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Profilebanexpire
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Blizzarddisplayname
    {
        public string type { get; set; }
    }

    public class UserUsertousercontext
    {
        public Properties59 properties { get; set; }
    }

    public class Properties59
    {
        public Isfollowing isFollowing { get; set; }
        public Ignorestatus ignoreStatus { get; set; }
        public Globalignoreenddate globalIgnoreEndDate { get; set; }
    }

    public class Isfollowing
    {
        public string type { get; set; }
    }

    public class Ignorestatus
    {
        public string _ref { get; set; }
    }

    public class Globalignoreenddate
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class IgnoresIgnoreresponse
    {
        public Properties60 properties { get; set; }
    }

    public class Properties60
    {
        public Isignored isIgnored { get; set; }
        public Ignoreflags ignoreFlags { get; set; }
    }

    public class Isignored
    {
        public string type { get; set; }
    }

    public class Ignoreflags
    {
        public string _ref { get; set; }
    }

    public class IgnoresIgnorestatus
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues1[] xenumvalues { get; set; }
    }

    public class XEnumValues1
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class UserModelsUseralias
    {
        public Properties61 properties { get; set; }
    }

    public class Properties61
    {
        public Cacheprefix cachePrefix { get; set; }
    }

    public class Cacheprefix
    {
        public string type { get; set; }
    }

    public class ConfigUsertheme
    {
        public Properties62 properties { get; set; }
    }

    public class Properties62
    {
        public Userthemeid userThemeId { get; set; }
        public Userthemename userThemeName { get; set; }
        public Userthemedescription userThemeDescription { get; set; }
    }

    public class Userthemeid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Userthemename
    {
        public string type { get; set; }
    }

    public class Userthemedescription
    {
        public string type { get; set; }
    }

    public class Bungiemembershiptype
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues2[] xenumvalues { get; set; }
    }

    public class XEnumValues2
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class UserUsermembershipdata
    {
        public Properties63 properties { get; set; }
    }

    public class Properties63
    {
        public Destinymemberships destinyMemberships { get; set; }
        public Bungienetuser bungieNetUser { get; set; }
    }

    public class Destinymemberships
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items16 items { get; set; }
    }

    public class Items16
    {
        public string _ref { get; set; }
    }

    public class Bungienetuser
    {
        public string _ref { get; set; }
    }

    public class UserUsermembership
    {
        public string description { get; set; }
        public Properties64 properties { get; set; }
    }

    public class Properties64
    {
        public Membershiptype membershipType { get; set; }
        public Membershipid1 membershipId { get; set; }
        public Displayname1 displayName { get; set; }
    }

    public class Membershiptype
    {
        public string description { get; set; }
        public Allof[] allOf { get; set; }
    }

    public class Allof
    {
        public string _ref { get; set; }
    }

    public class Membershipid1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displayname1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class UserUserinfocard
    {
        public string description { get; set; }
        public Properties65 properties { get; set; }
    }

    public class Properties65
    {
        public Supplementaldisplayname supplementalDisplayName { get; set; }
        public Iconpath iconPath { get; set; }
        public Membershiptype1 membershipType { get; set; }
        public Membershipid2 membershipId { get; set; }
        public Displayname2 displayName { get; set; }
    }

    public class Supplementaldisplayname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Iconpath
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Membershiptype1
    {
        public string description { get; set; }
        public Allof1[] allOf { get; set; }
    }

    public class Allof1
    {
        public string _ref { get; set; }
    }

    public class Membershipid2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displayname2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class PartnershipsPublicpartnershipdetail
    {
        public string description { get; set; }
        public Properties66 properties { get; set; }
    }

    public class Properties66
    {
        public Partnertype partnerType { get; set; }
        public Identifier identifier { get; set; }
        public Name name { get; set; }
        public Icon icon { get; set; }
    }

    public class Partnertype
    {
        public string _ref { get; set; }
    }

    public class Identifier
    {
        public string type { get; set; }
    }

    public class Name
    {
        public string type { get; set; }
    }

    public class Icon
    {
        public string type { get; set; }
    }

    public class PartnershipsPartnershiptype
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues3[] xenumvalues { get; set; }
    }

    public class XEnumValues3
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class ForumForumtopicscategoryfiltersenum
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues4[] xenumvalues { get; set; }
    }

    public class XEnumValues4
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class ForumForumtopicsquickdateenum
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues5[] xenumvalues { get; set; }
    }

    public class XEnumValues5
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class ForumForumtopicssortenum
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues6[] xenumvalues { get; set; }
    }

    public class XEnumValues6
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class ForumPostresponse
    {
        public Properties67 properties { get; set; }
    }

    public class Properties67
    {
        public Lastreplytimestamp lastReplyTimestamp { get; set; }
        public Ispinned IsPinned { get; set; }
        public Urlmediatype urlMediaType { get; set; }
        public Thumbnail thumbnail { get; set; }
        public Popularity popularity { get; set; }
        public Isactive isActive { get; set; }
        public Isannouncement isAnnouncement { get; set; }
        public Userrating userRating { get; set; }
        public Userhasrated userHasRated { get; set; }
        public Userhasmutedpost userHasMutedPost { get; set; }
        public Latestreplypostid latestReplyPostId { get; set; }
        public Latestreplyauthorid latestReplyAuthorId { get; set; }
        public Ignorestatus1 ignoreStatus { get; set; }
        public Locale1 locale { get; set; }
    }

    public class Lastreplytimestamp
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Ispinned
    {
        public string type { get; set; }
    }

    public class Urlmediatype
    {
        public string _ref { get; set; }
    }

    public class Thumbnail
    {
        public string type { get; set; }
    }

    public class Popularity
    {
        public string _ref { get; set; }
    }

    public class Isactive
    {
        public string type { get; set; }
    }

    public class Isannouncement
    {
        public string type { get; set; }
    }

    public class Userrating
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Userhasrated
    {
        public string type { get; set; }
    }

    public class Userhasmutedpost
    {
        public string type { get; set; }
    }

    public class Latestreplypostid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Latestreplyauthorid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Ignorestatus1
    {
        public string _ref { get; set; }
    }

    public class Locale1
    {
        public string type { get; set; }
    }

    public class ForumForummediatype
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues7[] xenumvalues { get; set; }
    }

    public class XEnumValues7
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class ForumForumpostpopularity
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues8[] xenumvalues { get; set; }
    }

    public class XEnumValues8
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class ForumForumpostcategoryenums
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues9[] xenumvalues { get; set; }
    }

    public class XEnumValues9
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class ForumForumflagsenum
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues10[] xenumvalues { get; set; }
    }

    public class XEnumValues10
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class QueriesSearchresult
    {
        public Properties68 properties { get; set; }
    }

    public class Properties68
    {
        public Totalresults totalResults { get; set; }
        public Hasmore hasMore { get; set; }
        public Query query { get; set; }
        public Replacementcontinuationtoken replacementContinuationToken { get; set; }
        public Usetotalresults useTotalResults { get; set; }
    }

    public class Totalresults
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Hasmore
    {
        public string type { get; set; }
    }

    public class Query
    {
        public string _ref { get; set; }
    }

    public class Replacementcontinuationtoken
    {
        public string type { get; set; }
    }

    public class Usetotalresults
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class QueriesPagedquery
    {
        public Properties69 properties { get; set; }
    }

    public class Properties69
    {
        public Itemsperpage itemsPerPage { get; set; }
        public Currentpage currentPage { get; set; }
        public Requestcontinuationtoken requestContinuationToken { get; set; }
    }

    public class Itemsperpage
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Currentpage
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Requestcontinuationtoken
    {
        public string type { get; set; }
    }

    public class Searchresultofpostresponse
    {
        public Properties70 properties { get; set; }
    }

    public class Properties70
    {
        public Results results { get; set; }
        public Totalresults1 totalResults { get; set; }
        public Hasmore1 hasMore { get; set; }
        public Query1 query { get; set; }
        public Replacementcontinuationtoken1 replacementContinuationToken { get; set; }
        public Usetotalresults1 useTotalResults { get; set; }
    }

    public class Results
    {
        public string type { get; set; }
        public Items17 items { get; set; }
    }

    public class Items17
    {
        public string _ref { get; set; }
    }

    public class Totalresults1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Hasmore1
    {
        public string type { get; set; }
    }

    public class Query1
    {
        public string _ref { get; set; }
    }

    public class Replacementcontinuationtoken1
    {
        public string type { get; set; }
    }

    public class Usetotalresults1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class ForumPostsearchresponse
    {
        public Properties71 properties { get; set; }
    }

    public class Properties71
    {
        public Relatedposts relatedPosts { get; set; }
        public Authors authors { get; set; }
        public Groups groups { get; set; }
        public Searchedtags searchedTags { get; set; }
        public Polls polls { get; set; }
        public Recruitmentdetails recruitmentDetails { get; set; }
        public Availablepages availablePages { get; set; }
        public Results1 results { get; set; }
        public Totalresults2 totalResults { get; set; }
        public Hasmore2 hasMore { get; set; }
        public Query2 query { get; set; }
        public Replacementcontinuationtoken2 replacementContinuationToken { get; set; }
        public Usetotalresults2 useTotalResults { get; set; }
    }

    public class Relatedposts
    {
        public string type { get; set; }
        public Items18 items { get; set; }
    }

    public class Items18
    {
        public string _ref { get; set; }
    }

    public class Authors
    {
        public string type { get; set; }
        public Items19 items { get; set; }
    }

    public class Items19
    {
        public string _ref { get; set; }
    }

    public class Groups
    {
        public string type { get; set; }
        public Items20 items { get; set; }
    }

    public class Items20
    {
        public string _ref { get; set; }
    }

    public class Searchedtags
    {
        public string type { get; set; }
        public Items21 items { get; set; }
    }

    public class Items21
    {
        public string _ref { get; set; }
    }

    public class Polls
    {
        public string type { get; set; }
        public Items22 items { get; set; }
    }

    public class Items22
    {
        public string _ref { get; set; }
    }

    public class Recruitmentdetails
    {
        public string type { get; set; }
        public Items23 items { get; set; }
    }

    public class Items23
    {
        public string _ref { get; set; }
    }

    public class Availablepages
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Results1
    {
        public string type { get; set; }
        public Items24 items { get; set; }
    }

    public class Items24
    {
        public string _ref { get; set; }
    }

    public class Totalresults2
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Hasmore2
    {
        public string type { get; set; }
    }

    public class Query2
    {
        public string _ref { get; set; }
    }

    public class Replacementcontinuationtoken2
    {
        public string type { get; set; }
    }

    public class Usetotalresults2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Groupsv2Groupresponse
    {
        public Properties72 properties { get; set; }
    }

    public class Properties72
    {
        public Detail detail { get; set; }
        public Founder founder { get; set; }
        public Alliedids alliedIds { get; set; }
        public Parentgroup parentGroup { get; set; }
        public Alliancestatus allianceStatus { get; set; }
        public Groupjoininvitecount groupJoinInviteCount { get; set; }
        public Currentusermembermap currentUserMemberMap { get; set; }
        public Currentuserpotentialmembermap currentUserPotentialMemberMap { get; set; }
    }

    public class Detail
    {
        public string _ref { get; set; }
    }

    public class Founder
    {
        public string _ref { get; set; }
    }

    public class Alliedids
    {
        public string type { get; set; }
        public Items25 items { get; set; }
    }

    public class Items25
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Parentgroup
    {
        public string _ref { get; set; }
    }

    public class Alliancestatus
    {
        public string _ref { get; set; }
    }

    public class Groupjoininvitecount
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Currentusermembermap
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties67 additionalProperties { get; set; }
    }

    public class Additionalproperties67
    {
        public string _ref { get; set; }
    }

    public class Currentuserpotentialmembermap
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties68 additionalProperties { get; set; }
    }

    public class Additionalproperties68
    {
        public string _ref { get; set; }
    }

    public class Groupsv2Groupv2
    {
        public Properties73 properties { get; set; }
    }

    public class Properties73
    {
        public Groupid groupId { get; set; }
        public Name1 name { get; set; }
        public Grouptype groupType { get; set; }
        public Membershipidcreated membershipIdCreated { get; set; }
        public Creationdate creationDate { get; set; }
        public Modificationdate modificationDate { get; set; }
        public About1 about { get; set; }
        public Tags tags { get; set; }
        public Membercount memberCount { get; set; }
        public Ispublic isPublic { get; set; }
        public Ispublictopicadminonly isPublicTopicAdminOnly { get; set; }
        public Primaryalliedgroupid primaryAlliedGroupId { get; set; }
        public Motto motto { get; set; }
        public Allowchat allowChat { get; set; }
        public Isdefaultpostpublic isDefaultPostPublic { get; set; }
        public Chatsecurity chatSecurity { get; set; }
        public Locale2 locale { get; set; }
        public Avatarimageindex avatarImageIndex { get; set; }
        public Homepage homepage { get; set; }
        public Membershipoption membershipOption { get; set; }
        public Defaultpublicity defaultPublicity { get; set; }
        public Theme theme { get; set; }
        public Bannerpath bannerPath { get; set; }
        public Avatarpath avatarPath { get; set; }
        public Isallianceowner isAllianceOwner { get; set; }
        public Conversationid conversationId { get; set; }
        public Enableinvitationmessagingforadmins enableInvitationMessagingForAdmins { get; set; }
        public Banexpiredate banExpireDate { get; set; }
        public Features features { get; set; }
        public Claninfo clanInfo { get; set; }
    }

    public class Groupid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Name1
    {
        public string type { get; set; }
    }

    public class Grouptype
    {
        public string _ref { get; set; }
    }

    public class Membershipidcreated
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Creationdate
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Modificationdate
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class About1
    {
        public string type { get; set; }
    }

    public class Tags
    {
        public string type { get; set; }
        public Items26 items { get; set; }
    }

    public class Items26
    {
        public string type { get; set; }
    }

    public class Membercount
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Ispublic
    {
        public string type { get; set; }
    }

    public class Ispublictopicadminonly
    {
        public string type { get; set; }
    }

    public class Primaryalliedgroupid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Motto
    {
        public string type { get; set; }
    }

    public class Allowchat
    {
        public string type { get; set; }
    }

    public class Isdefaultpostpublic
    {
        public string type { get; set; }
    }

    public class Chatsecurity
    {
        public string _ref { get; set; }
    }

    public class Locale2
    {
        public string type { get; set; }
    }

    public class Avatarimageindex
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Homepage
    {
        public string _ref { get; set; }
    }

    public class Membershipoption
    {
        public string _ref { get; set; }
    }

    public class Defaultpublicity
    {
        public string _ref { get; set; }
    }

    public class Theme
    {
        public string type { get; set; }
    }

    public class Bannerpath
    {
        public string type { get; set; }
    }

    public class Avatarpath
    {
        public string type { get; set; }
    }

    public class Isallianceowner
    {
        public string type { get; set; }
    }

    public class Conversationid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Enableinvitationmessagingforadmins
    {
        public string type { get; set; }
    }

    public class Banexpiredate
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Features
    {
        public string _ref { get; set; }
    }

    public class Claninfo
    {
        public string _ref { get; set; }
    }

    public class Groupsv2Grouptype
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues11[] xenumvalues { get; set; }
    }

    public class XEnumValues11
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class Groupsv2Chatsecuritysetting
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues12[] xenumvalues { get; set; }
    }

    public class XEnumValues12
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class Groupsv2Grouphomepage
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues13[] xenumvalues { get; set; }
    }

    public class XEnumValues13
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class Groupsv2Membershipoption
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues14[] xenumvalues { get; set; }
    }

    public class XEnumValues14
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class Groupsv2Grouppostpublicity
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues15[] xenumvalues { get; set; }
    }

    public class XEnumValues15
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class Groupsv2Groupfeatures
    {
        public Properties74 properties { get; set; }
    }

    public class Properties74
    {
        public Maximummembers maximumMembers { get; set; }
        public Maximummembershipsofgrouptype maximumMembershipsOfGroupType { get; set; }
        public Capabilities capabilities { get; set; }
        public Membershiptypes membershipTypes { get; set; }
        public Invitepermissionoverride invitePermissionOverride { get; set; }
        public Updateculturepermissionoverride updateCulturePermissionOverride { get; set; }
        public Hostguidedgamepermissionoverride hostGuidedGamePermissionOverride { get; set; }
        public Updatebannerpermissionoverride updateBannerPermissionOverride { get; set; }
        public Joinlevel joinLevel { get; set; }
    }

    public class Maximummembers
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Maximummembershipsofgrouptype
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Capabilities
    {
        public string _ref { get; set; }
    }

    public class Membershiptypes
    {
        public string type { get; set; }
        public Items27 items { get; set; }
    }

    public class Items27
    {
        public string _ref { get; set; }
    }

    public class Invitepermissionoverride
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Updateculturepermissionoverride
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hostguidedgamepermissionoverride
    {
        public string description { get; set; }
        public Allof2[] allOf { get; set; }
    }

    public class Allof2
    {
        public string _ref { get; set; }
    }

    public class Updatebannerpermissionoverride
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Joinlevel
    {
        public string description { get; set; }
        public Allof3[] allOf { get; set; }
    }

    public class Allof3
    {
        public string _ref { get; set; }
    }

    public class Groupsv2Capabilities
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues16[] xenumvalues { get; set; }
    }

    public class XEnumValues16
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }
    
    public class Items28
    {
        public string _ref { get; set; }
    }

    public class Groupsv2Hostguidedgamespermissionlevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues17[] xenumvalues { get; set; }
    }

    public class XEnumValues17
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class Groupsv2Runtimegroupmembertype
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues18[] xenumvalues { get; set; }
    }

    public class XEnumValues18
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class Groupsv2Groupv2claninfo
    {
        public string description { get; set; }
        public Properties75 properties { get; set; }
    }

    public class Properties75
    {
        public Clancallsign clanCallsign { get; set; }
        public Clanbannerdata clanBannerData { get; set; }
    }

    public class Clancallsign
    {
        public string type { get; set; }
    }

    public class Clanbannerdata
    {
        public string _ref { get; set; }
    }

    public class Groupsv2Clanbanner
    {
        public Properties76 properties { get; set; }
    }

    public class Properties76
    {
        public Decalid decalId { get; set; }
        public Decalcolorid decalColorId { get; set; }
        public Decalbackgroundcolorid decalBackgroundColorId { get; set; }
        public Gonfalonid gonfalonId { get; set; }
        public Gonfaloncolorid gonfalonColorId { get; set; }
        public Gonfalondetailid gonfalonDetailId { get; set; }
        public Gonfalondetailcolorid gonfalonDetailColorId { get; set; }
    }

    public class Decalid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Decalcolorid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Decalbackgroundcolorid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Gonfalonid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Gonfaloncolorid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Gonfalondetailid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Gonfalondetailcolorid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Groupsv2Groupv2claninfoandinvestment
    {
        public string description { get; set; }
        public Properties77 properties { get; set; }
    }

    public class Properties77
    {
        public D2clanprogressions d2ClanProgressions { get; set; }
        public Clancallsign1 clanCallsign { get; set; }
        public Clanbannerdata1 clanBannerData { get; set; }
    }

    public class D2clanprogressions
    {
        public string type { get; set; }
        public Additionalproperties69 additionalProperties { get; set; }
    }

    public class Additionalproperties69
    {
        public string _ref { get; set; }
    }

    public class Clancallsign1
    {
        public string type { get; set; }
    }

    public class Clanbannerdata1
    {
        public string _ref { get; set; }
    }

    public class DestinyDestinyprogression
    {
        public string description { get; set; }
        public Properties78 properties { get; set; }
    }

    public class Properties78
    {
        public Progressionhash progressionHash { get; set; }
        public Dailyprogress dailyProgress { get; set; }
        public Dailylimit dailyLimit { get; set; }
        public Weeklyprogress weeklyProgress { get; set; }
        public Weeklylimit weeklyLimit { get; set; }
        public Currentprogress currentProgress { get; set; }
        public Level level { get; set; }
        public Levelcap levelCap { get; set; }
        public Stepindex stepIndex { get; set; }
        public Progresstonextlevel progressToNextLevel { get; set; }
        public Nextlevelat nextLevelAt { get; set; }
    }

    public class Progressionhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition xmappeddefinition { get; set; }
    }

    public class XMappedDefinition
    {
        public string _ref { get; set; }
    }

    public class Dailyprogress
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Dailylimit
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Weeklyprogress
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Weeklylimit
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Currentprogress
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Level
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Levelcap
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Stepindex
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Progresstonextlevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Nextlevelat
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinydefinition
    {
        public string description { get; set; }
        public Properties79 properties { get; set; }
    }

    public class Properties79
    {
        public Hash hash { get; set; }
        public Index index { get; set; }
        public Redacted redacted { get; set; }
    }

    public class Hash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyprogressiondefinition
    {
        public string description { get; set; }
        public Properties80 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties80
    {
        public Displayproperties displayProperties { get; set; }
        public Scope scope { get; set; }
        public Repeatlaststep repeatLastStep { get; set; }
        public Source source { get; set; }
        public Steps steps { get; set; }
        public Visible visible { get; set; }
        public Factionhash factionHash { get; set; }
        public Hash1 hash { get; set; }
        public Index1 index { get; set; }
        public Redacted1 redacted { get; set; }
    }

    public class Displayproperties
    {
        public string _ref { get; set; }
    }

    public class Scope
    {
        public string description { get; set; }
        public Allof4[] allOf { get; set; }
    }

    public class Allof4
    {
        public string _ref { get; set; }
    }

    public class Repeatlaststep
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Source
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Steps
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items29 items { get; set; }
    }

    public class Items29
    {
        public string _ref { get; set; }
    }

    public class Visible
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Factionhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition1 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition1
    {
        public string _ref { get; set; }
    }

    public class Hash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsCommonDestinydisplaypropertiesdefinition
    {
        public string description { get; set; }
        public Properties81 properties { get; set; }
    }

    public class Properties81
    {
        public Description description { get; set; }
        public Name2 name { get; set; }
        public Icon1 icon { get; set; }
        public Hasicon hasIcon { get; set; }
    }

    public class Description
    {
        public string type { get; set; }
    }

    public class Name2
    {
        public string type { get; set; }
    }

    public class Icon1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hasicon
    {
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyprogressiondisplaypropertiesdefinition
    {
        public Properties82 properties { get; set; }
    }

    public class Properties82
    {
        public Displayunitsname displayUnitsName { get; set; }
        public Description1 description { get; set; }
        public Name3 name { get; set; }
        public Icon2 icon { get; set; }
        public Hasicon1 hasIcon { get; set; }
    }

    public class Displayunitsname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Description1
    {
        public string type { get; set; }
    }

    public class Name3
    {
        public string type { get; set; }
    }

    public class Icon2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hasicon1
    {
        public string type { get; set; }
    }

    public class DestinyDestinyprogressionscope
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues19[] xenumvalues { get; set; }
    }

    public class XEnumValues19
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinyprogressionstepdefinition
    {
        public string description { get; set; }
        public Properties83 properties { get; set; }
    }

    public class Properties83
    {
        public Stepname stepName { get; set; }
        public Displayeffecttype displayEffectType { get; set; }
        public Progresstotal progressTotal { get; set; }
        public Rewarditems rewardItems { get; set; }
    }

    public class Stepname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displayeffecttype
    {
        public string description { get; set; }
        public Allof5[] allOf { get; set; }
    }

    public class Allof5
    {
        public string _ref { get; set; }
    }

    public class Progresstotal
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Rewarditems
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items30 items { get; set; }
    }

    public class Items30
    {
        public string _ref { get; set; }
    }

    public class DestinyDestinyprogressionstepdisplayeffect
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues20[] xenumvalues { get; set; }
    }

    public class XEnumValues20
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDestinyitemquantity
    {
        public string description { get; set; }
        public Properties84 properties { get; set; }
    }

    public class Properties84
    {
        public Itemhash itemHash { get; set; }
        public Iteminstanceid itemInstanceId { get; set; }
        public Quantity quantity { get; set; }
    }

    public class Itemhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition2 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition2
    {
        public string _ref { get; set; }
    }

    public class Iteminstanceid
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Quantity
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyinventoryitemdefinition
    {
        public string description { get; set; }
        public Properties85 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties85
    {
        public Displayproperties1 displayProperties { get; set; }
        public Secondaryicon secondaryIcon { get; set; }
        public Secondaryoverlay secondaryOverlay { get; set; }
        public Secondaryspecial secondarySpecial { get; set; }
        public Screenshot screenshot { get; set; }
        public Itemtypedisplayname itemTypeDisplayName { get; set; }
        public Itemtypeandtierdisplayname itemTypeAndTierDisplayName { get; set; }
        public Displaysource displaySource { get; set; }
        public Tooltipstyle tooltipStyle { get; set; }
        public Action action { get; set; }
        public Inventory inventory { get; set; }
        public Setdata setData { get; set; }
        public Stats stats { get; set; }
        public Equippingblock equippingBlock { get; set; }
        public Translationblock translationBlock { get; set; }
        public Preview preview { get; set; }
        public Quality quality { get; set; }
        public Value value { get; set; }
        public Sourcedata sourceData { get; set; }
        public Objectives objectives { get; set; }
        public Plug plug { get; set; }
        public Gearset gearset { get; set; }
        public Sack sack { get; set; }
        public Sockets sockets { get; set; }
        public Summary summary { get; set; }
        public Talentgrid talentGrid { get; set; }
        public Investmentstats investmentStats { get; set; }
        public Perks perks { get; set; }
        public Lorehash loreHash { get; set; }
        public Summaryitemhash summaryItemHash { get; set; }
        public Animations animations { get; set; }
        public Allowactions allowActions { get; set; }
        public Links links { get; set; }
        public Nontransferrable nonTransferrable { get; set; }
        public Itemcategoryhashes itemCategoryHashes { get; set; }
        public Specialitemtype specialItemType { get; set; }
        public Itemtype itemType { get; set; }
        public Itemsubtype itemSubType { get; set; }
        public Classtype classType { get; set; }
        public Equippable equippable { get; set; }
        public Damagetypehashes damageTypeHashes { get; set; }
        public Damagetypes damageTypes { get; set; }
        public Defaultdamagetype defaultDamageType { get; set; }
        public Defaultdamagetypehash defaultDamageTypeHash { get; set; }
        public Hash2 hash { get; set; }
        public Index2 index { get; set; }
        public Redacted2 redacted { get; set; }
    }

    public class Displayproperties1
    {
        public string _ref { get; set; }
    }

    public class Secondaryicon
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Secondaryoverlay
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Secondaryspecial
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Screenshot
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemtypedisplayname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemtypeandtierdisplayname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displaysource
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Tooltipstyle
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Action
    {
        public string description { get; set; }
        public Allof6[] allOf { get; set; }
    }

    public class Allof6
    {
        public string _ref { get; set; }
    }

    public class Inventory
    {
        public string description { get; set; }
        public Allof7[] allOf { get; set; }
    }

    public class Allof7
    {
        public string _ref { get; set; }
    }

    public class Setdata
    {
        public string description { get; set; }
        public Allof8[] allOf { get; set; }
    }

    public class Allof8
    {
        public string _ref { get; set; }
    }

    public class Stats
    {
        public string description { get; set; }
        public Allof9[] allOf { get; set; }
    }

    public class Allof9
    {
        public string _ref { get; set; }
    }

    public class Equippingblock
    {
        public string description { get; set; }
        public Allof10[] allOf { get; set; }
    }

    public class Allof10
    {
        public string _ref { get; set; }
    }

    public class Translationblock
    {
        public string description { get; set; }
        public Allof11[] allOf { get; set; }
    }

    public class Allof11
    {
        public string _ref { get; set; }
    }

    public class Preview
    {
        public string description { get; set; }
        public Allof12[] allOf { get; set; }
    }

    public class Allof12
    {
        public string _ref { get; set; }
    }

    public class Quality
    {
        public string description { get; set; }
        public Allof13[] allOf { get; set; }
    }

    public class Allof13
    {
        public string _ref { get; set; }
    }

    public class Value
    {
        public string description { get; set; }
        public Allof14[] allOf { get; set; }
    }

    public class Allof14
    {
        public string _ref { get; set; }
    }

    public class Sourcedata
    {
        public string description { get; set; }
        public Allof15[] allOf { get; set; }
    }

    public class Allof15
    {
        public string _ref { get; set; }
    }

    public class Objectives
    {
        public string description { get; set; }
        public Allof16[] allOf { get; set; }
    }

    public class Allof16
    {
        public string _ref { get; set; }
    }

    public class Plug
    {
        public string description { get; set; }
        public Allof17[] allOf { get; set; }
    }

    public class Allof17
    {
        public string _ref { get; set; }
    }

    public class Gearset
    {
        public string description { get; set; }
        public Allof18[] allOf { get; set; }
    }

    public class Allof18
    {
        public string _ref { get; set; }
    }

    public class Sack
    {
        public string description { get; set; }
        public Allof19[] allOf { get; set; }
    }

    public class Allof19
    {
        public string _ref { get; set; }
    }

    public class Sockets
    {
        public string description { get; set; }
        public Allof20[] allOf { get; set; }
    }

    public class Allof20
    {
        public string _ref { get; set; }
    }

    public class Summary
    {
        public string description { get; set; }
        public Allof21[] allOf { get; set; }
    }

    public class Allof21
    {
        public string _ref { get; set; }
    }

    public class Talentgrid
    {
        public string description { get; set; }
        public Allof22[] allOf { get; set; }
    }

    public class Allof22
    {
        public string _ref { get; set; }
    }

    public class Investmentstats
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items31 items { get; set; }
    }

    public class Items31
    {
        public string _ref { get; set; }
    }

    public class Perks
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items32 items { get; set; }
    }

    public class Items32
    {
        public string _ref { get; set; }
    }

    public class Lorehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition3 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition3
    {
        public string _ref { get; set; }
    }

    public class Summaryitemhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition4 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition4
    {
        public string _ref { get; set; }
    }

    public class Animations
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items33 items { get; set; }
    }

    public class Items33
    {
        public string _ref { get; set; }
    }

    public class Allowactions
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Links
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items34 items { get; set; }
    }

    public class Items34
    {
        public string _ref { get; set; }
    }

    public class Nontransferrable
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemcategoryhashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items35 items { get; set; }
        public XMappedDefinition5 xmappeddefinition { get; set; }
    }

    public class Items35
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition5
    {
        public string _ref { get; set; }
    }

    public class Specialitemtype
    {
        public string description { get; set; }
        public Allof23[] allOf { get; set; }
    }

    public class Allof23
    {
        public string _ref { get; set; }
    }

    public class Itemtype
    {
        public string description { get; set; }
        public Allof24[] allOf { get; set; }
    }

    public class Allof24
    {
        public string _ref { get; set; }
    }

    public class Itemsubtype
    {
        public string description { get; set; }
        public Allof25[] allOf { get; set; }
    }

    public class Allof25
    {
        public string _ref { get; set; }
    }

    public class Classtype
    {
        public string description { get; set; }
        public Allof26[] allOf { get; set; }
    }

    public class Allof26
    {
        public string _ref { get; set; }
    }

    public class Equippable
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Damagetypehashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items36 items { get; set; }
        public XMappedDefinition6 xmappeddefinition { get; set; }
    }

    public class Items36
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition6
    {
        public string _ref { get; set; }
    }

    public class Damagetypes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items37 items { get; set; }
    }

    public class Items37
    {
        public string _ref { get; set; }
    }

    public class Defaultdamagetype
    {
        public string description { get; set; }
        public Allof27[] allOf { get; set; }
    }

    public class Allof27
    {
        public string _ref { get; set; }
    }

    public class Defaultdamagetypehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition7 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition7
    {
        public string _ref { get; set; }
    }

    public class Hash2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyitemactionblockdefinition
    {
        public string description { get; set; }
        public Properties86 properties { get; set; }
    }

    public class Properties86
    {
        public Verbname verbName { get; set; }
        public Verbdescription verbDescription { get; set; }
        public Ispositive isPositive { get; set; }
        public Overlayscreenname overlayScreenName { get; set; }
        public Overlayicon overlayIcon { get; set; }
        public Requiredcooldownseconds requiredCooldownSeconds { get; set; }
        public Requireditems requiredItems { get; set; }
        public Progressionrewards progressionRewards { get; set; }
        public Actiontypelabel actionTypeLabel { get; set; }
        public Requiredlocation requiredLocation { get; set; }
        public Requiredcooldownhash requiredCooldownHash { get; set; }
        public Deleteonaction deleteOnAction { get; set; }
        public Consumeentirestack consumeEntireStack { get; set; }
        public Useonacquire useOnAcquire { get; set; }
    }

    public class Verbname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Verbdescription
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Ispositive
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Overlayscreenname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Overlayicon
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Requiredcooldownseconds
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Requireditems
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items38 items { get; set; }
    }

    public class Items38
    {
        public string _ref { get; set; }
    }

    public class Progressionrewards
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items39 items { get; set; }
    }

    public class Items39
    {
        public string _ref { get; set; }
    }

    public class Actiontypelabel
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Requiredlocation
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Requiredcooldownhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Deleteonaction
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Consumeentirestack
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Useonacquire
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyitemactionrequireditemdefinition
    {
        public string description { get; set; }
        public Properties87 properties { get; set; }
    }

    public class Properties87
    {
        public Count count { get; set; }
        public Itemhash1 itemHash { get; set; }
        public Deleteonaction1 deleteOnAction { get; set; }
    }

    public class Count
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition8 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition8
    {
        public string _ref { get; set; }
    }

    public class Deleteonaction1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyprogressionrewarddefinition
    {
        public string description { get; set; }
        public Properties88 properties { get; set; }
    }

    public class Properties88
    {
        public Progressionmappinghash progressionMappingHash { get; set; }
        public Amount amount { get; set; }
        public Applythrottles applyThrottles { get; set; }
    }

    public class Progressionmappinghash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition9 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition9
    {
        public string _ref { get; set; }
    }

    public class Amount
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Applythrottles
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyprogressionmappingdefinition
    {
        public string description { get; set; }
        public Properties89 properties { get; set; }
    }

    public class Properties89
    {
        public Displayproperties2 displayProperties { get; set; }
        public Displayunits displayUnits { get; set; }
        public Hash3 hash { get; set; }
        public Index3 index { get; set; }
        public Redacted3 redacted { get; set; }
    }

    public class Displayproperties2
    {
        public string description { get; set; }
        public Allof28[] allOf { get; set; }
    }

    public class Allof28
    {
        public string _ref { get; set; }
    }

    public class Displayunits
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hash3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyiteminventoryblockdefinition
    {
        public string description { get; set; }
        public Properties90 properties { get; set; }
    }

    public class Properties90
    {
        public Stackuniquelabel stackUniqueLabel { get; set; }
        public Maxstacksize maxStackSize { get; set; }
        public Buckettypehash bucketTypeHash { get; set; }
        public Recoverybuckettypehash recoveryBucketTypeHash { get; set; }
        public Tiertypehash tierTypeHash { get; set; }
        public Isinstanceitem isInstanceItem { get; set; }
        public Tiertypename tierTypeName { get; set; }
        public Tiertype tierType { get; set; }
    }

    public class Stackuniquelabel
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Maxstacksize
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Buckettypehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition10 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition10
    {
        public string _ref { get; set; }
    }

    public class Recoverybuckettypehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition11 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition11
    {
        public string _ref { get; set; }
    }

    public class Tiertypehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition12 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition12
    {
        public string _ref { get; set; }
    }

    public class Isinstanceitem
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Tiertypename
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Tiertype
    {
        public string description { get; set; }
        public Allof29[] allOf { get; set; }
    }

    public class Allof29
    {
        public string _ref { get; set; }
    }

    public class DestinyTiertype
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues21[] xenumvalues { get; set; }
    }

    public class XEnumValues21
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinyinventorybucketdefinition
    {
        public string description { get; set; }
        public Properties91 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties91
    {
        public Displayproperties3 displayProperties { get; set; }
        public Scope1 scope { get; set; }
        public Category category { get; set; }
        public Bucketorder bucketOrder { get; set; }
        public Itemcount itemCount { get; set; }
        public Location location { get; set; }
        public Hastransferdestination hasTransferDestination { get; set; }
        public Enabled enabled { get; set; }
        public Fifo fifo { get; set; }
        public Hash4 hash { get; set; }
        public Index4 index { get; set; }
        public Redacted4 redacted { get; set; }
    }

    public class Displayproperties3
    {
        public string _ref { get; set; }
    }

    public class Scope1
    {
        public string description { get; set; }
        public Allof30[] allOf { get; set; }
    }

    public class Allof30
    {
        public string _ref { get; set; }
    }

    public class Category
    {
        public string description { get; set; }
        public Allof31[] allOf { get; set; }
    }

    public class Allof31
    {
        public string _ref { get; set; }
    }

    public class Bucketorder
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemcount
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Location
    {
        public string description { get; set; }
        public Allof32[] allOf { get; set; }
    }

    public class Allof32
    {
        public string _ref { get; set; }
    }

    public class Hastransferdestination
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Enabled
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Fifo
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hash4
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index4
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted4
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyBucketscope
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues22[] xenumvalues { get; set; }
    }

    public class XEnumValues22
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyBucketcategory
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues23[] xenumvalues { get; set; }
    }

    public class XEnumValues23
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyItemlocation
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues24[] xenumvalues { get; set; }
    }

    public class XEnumValues24
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsItemsDestinyitemtiertypedefinition
    {
        public string description { get; set; }
        public Properties92 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties92
    {
        public Displayproperties4 displayProperties { get; set; }
        public Infusionprocess infusionProcess { get; set; }
        public Hash5 hash { get; set; }
        public Index5 index { get; set; }
        public Redacted5 redacted { get; set; }
    }

    public class Displayproperties4
    {
        public string _ref { get; set; }
    }

    public class Infusionprocess
    {
        public string description { get; set; }
        public Allof33[] allOf { get; set; }
    }

    public class Allof33
    {
        public string _ref { get; set; }
    }

    public class Hash5
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index5
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted5
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsItemsDestinyitemtiertypeinfusionblock
    {
        public Properties93 properties { get; set; }
    }

    public class Properties93
    {
        public Basequalitytransferratio baseQualityTransferRatio { get; set; }
        public Minimumqualityincrement minimumQualityIncrement { get; set; }
    }

    public class Basequalitytransferratio
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Minimumqualityincrement
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyitemsetblockdefinition
    {
        public string description { get; set; }
        public Properties94 properties { get; set; }
    }

    public class Properties94
    {
        public Itemlist itemList { get; set; }
        public Requireorderedsetitemadd requireOrderedSetItemAdd { get; set; }
        public Setisfeatured setIsFeatured { get; set; }
        public Settype setType { get; set; }
    }

    public class Itemlist
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items40 items { get; set; }
    }

    public class Items40
    {
        public string _ref { get; set; }
    }

    public class Requireorderedsetitemadd
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Setisfeatured
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Settype
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyitemsetblockentrydefinition
    {
        public string description { get; set; }
        public Properties95 properties { get; set; }
    }

    public class Properties95
    {
        public Trackingvalue trackingValue { get; set; }
        public Itemhash2 itemHash { get; set; }
    }

    public class Trackingvalue
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemhash2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition13 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition13
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyitemstatblockdefinition
    {
        public string description { get; set; }
        public Properties96 properties { get; set; }
    }

    public class Properties96
    {
        public Statgrouphash statGroupHash { get; set; }
        public Stats1 stats { get; set; }
        public Hasdisplayablestats hasDisplayableStats { get; set; }
        public Primarybasestathash primaryBaseStatHash { get; set; }
    }

    public class Statgrouphash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition14 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition14
    {
        public string _ref { get; set; }
    }

    public class Stats1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties70 additionalProperties { get; set; }
        public XMappedDefinition15 xmappeddefinition { get; set; }
    }

    public class Additionalproperties70
    {
        public string _ref { get; set; }
    }

    public class XMappedDefinition15
    {
        public string _ref { get; set; }
    }

    public class Hasdisplayablestats
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Primarybasestathash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition16 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition16
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyinventoryitemstatdefinition
    {
        public string description { get; set; }
        public Properties97 properties { get; set; }
    }

    public class Properties97
    {
        public Stathash statHash { get; set; }
        public Value1 value { get; set; }
        public Minimum minimum { get; set; }
        public Maximum maximum { get; set; }
    }

    public class Stathash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition17 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition17
    {
        public string _ref { get; set; }
    }

    public class Value1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Minimum
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Maximum
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinystatdefinition
    {
        public string description { get; set; }
        public Properties98 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties98
    {
        public Displayproperties5 displayProperties { get; set; }
        public Aggregationtype aggregationType { get; set; }
        public Hascomputedblock hasComputedBlock { get; set; }
        public Hash6 hash { get; set; }
        public Index6 index { get; set; }
        public Redacted6 redacted { get; set; }
    }

    public class Displayproperties5
    {
        public string _ref { get; set; }
    }

    public class Aggregationtype
    {
        public string description { get; set; }
        public Allof34[] allOf { get; set; }
    }

    public class Allof34
    {
        public string _ref { get; set; }
    }

    public class Hascomputedblock
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hash6
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index6
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted6
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDestinystataggregationtype
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues25[] xenumvalues { get; set; }
    }

    public class XEnumValues25
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinystatgroupdefinition
    {
        public string description { get; set; }
        public Properties99 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties99
    {
        public Maximumvalue maximumValue { get; set; }
        public Uiposition uiPosition { get; set; }
        public Scaledstats scaledStats { get; set; }
        public Overrides overrides { get; set; }
        public Hash7 hash { get; set; }
        public Index7 index { get; set; }
        public Redacted7 redacted { get; set; }
    }

    public class Maximumvalue
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Uiposition
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Scaledstats
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items41 items { get; set; }
    }

    public class Items41
    {
        public string _ref { get; set; }
    }

    public class Overrides
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties71 additionalProperties { get; set; }
    }

    public class Additionalproperties71
    {
        public string _ref { get; set; }
    }

    public class Hash7
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index7
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted7
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinystatdisplaydefinition
    {
        public string description { get; set; }
        public Properties100 properties { get; set; }
    }

    public class Properties100
    {
        public Stathash1 statHash { get; set; }
        public Maximumvalue1 maximumValue { get; set; }
        public Displayasnumeric displayAsNumeric { get; set; }
        public Displayinterpolation displayInterpolation { get; set; }
    }

    public class Stathash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition18 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition18
    {
        public string _ref { get; set; }
    }

    public class Maximumvalue1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displayasnumeric
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displayinterpolation
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items42 items { get; set; }
    }

    public class Items42
    {
        public string _ref { get; set; }
    }

    public class InterpolationInterpolationpoint
    {
        public Properties101 properties { get; set; }
    }

    public class Properties101
    {
        public Value2 value { get; set; }
        public Weight weight { get; set; }
    }

    public class Value2
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Weight
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinystatoverridedefinition
    {
        public string description { get; set; }
        public Properties102 properties { get; set; }
    }

    public class Properties102
    {
        public Stathash2 statHash { get; set; }
        public Displayproperties6 displayProperties { get; set; }
    }

    public class Stathash2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition19 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition19
    {
        public string _ref { get; set; }
    }

    public class Displayproperties6
    {
        public string description { get; set; }
        public Allof35[] allOf { get; set; }
    }

    public class Allof35
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyequippingblockdefinition
    {
        public string description { get; set; }
        public Properties103 properties { get; set; }
    }

    public class Properties103
    {
        public Gearsetitemhash gearsetItemHash { get; set; }
        public Uniquelabel uniqueLabel { get; set; }
        public Uniquelabelhash uniqueLabelHash { get; set; }
        public Equipmentslottypehash equipmentSlotTypeHash { get; set; }
        public Attributes attributes { get; set; }
        public Displaystrings displayStrings { get; set; }
    }

    public class Gearsetitemhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition20 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition20
    {
        public string _ref { get; set; }
    }

    public class Uniquelabel
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Uniquelabelhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Equipmentslottypehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition21 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition21
    {
        public string _ref { get; set; }
    }

    public class Attributes
    {
        public string description { get; set; }
        public Allof36[] allOf { get; set; }
    }

    public class Allof36
    {
        public string _ref { get; set; }
    }

    public class Displaystrings
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items43 items { get; set; }
    }

    public class Items43
    {
        public string type { get; set; }
    }

    public class DestinyEquippingitemblockattributes
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues26[] xenumvalues { get; set; }
    }

    public class XEnumValues26
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinyequipmentslotdefinition
    {
        public string description { get; set; }
        public Properties104 properties { get; set; }
    }

    public class Properties104
    {
        public Displayproperties7 displayProperties { get; set; }
        public Equipmentcategoryhash equipmentCategoryHash { get; set; }
        public Buckettypehash1 bucketTypeHash { get; set; }
        public Applycustomartdyes applyCustomArtDyes { get; set; }
        public Hash8 hash { get; set; }
        public Index8 index { get; set; }
        public Redacted8 redacted { get; set; }
    }

    public class Displayproperties7
    {
        public string _ref { get; set; }
    }

    public class Equipmentcategoryhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Buckettypehash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition22 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition22
    {
        public string _ref { get; set; }
    }

    public class Applycustomartdyes
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hash8
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index8
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted8
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyitemtranslationblockdefinition
    {
        public string description { get; set; }
        public Properties105 properties { get; set; }
    }

    public class Properties105
    {
        public Weaponpatternidentifier weaponPatternIdentifier { get; set; }
        public Weaponpatternhash weaponPatternHash { get; set; }
        public Defaultdyes defaultDyes { get; set; }
        public Lockeddyes lockedDyes { get; set; }
        public Customdyes customDyes { get; set; }
        public Arrangements arrangements { get; set; }
        public Hasgeometry hasGeometry { get; set; }
    }

    public class Weaponpatternidentifier
    {
        public string type { get; set; }
    }

    public class Weaponpatternhash
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Defaultdyes
    {
        public string type { get; set; }
        public Items44 items { get; set; }
    }

    public class Items44
    {
        public string _ref { get; set; }
    }

    public class Lockeddyes
    {
        public string type { get; set; }
        public Items45 items { get; set; }
    }

    public class Items45
    {
        public string _ref { get; set; }
    }

    public class Customdyes
    {
        public string type { get; set; }
        public Items46 items { get; set; }
    }

    public class Items46
    {
        public string _ref { get; set; }
    }

    public class Arrangements
    {
        public string type { get; set; }
        public Items47 items { get; set; }
    }

    public class Items47
    {
        public string _ref { get; set; }
    }

    public class Hasgeometry
    {
        public string type { get; set; }
    }

    public class DestinyDyereference
    {
        public Properties106 properties { get; set; }
    }

    public class Properties106
    {
        public Channelhash channelHash { get; set; }
        public Dyehash dyeHash { get; set; }
    }

    public class Channelhash
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Dyehash
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinygearartarrangementreference
    {
        public Properties107 properties { get; set; }
    }

    public class Properties107
    {
        public Classhash classHash { get; set; }
        public Artarrangementhash artArrangementHash { get; set; }
    }

    public class Classhash
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Artarrangementhash
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyitempreviewblockdefinition
    {
        public string description { get; set; }
        public Properties108 properties { get; set; }
    }

    public class Properties108
    {
        public Previewvendorhash previewVendorHash { get; set; }
        public Previewactionstring previewActionString { get; set; }
        public Deriveditemcategories derivedItemCategories { get; set; }
    }

    public class Previewvendorhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition23 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition23
    {
        public string _ref { get; set; }
    }

    public class Previewactionstring
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Deriveditemcategories
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items48 items { get; set; }
    }

    public class Items48
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsItemsDestinyderiveditemcategorydefinition
    {
        public string description { get; set; }
        public Properties109 properties { get; set; }
    }

    public class Properties109
    {
        public Categorydescription categoryDescription { get; set; }
        public Items49 items { get; set; }
    }

    public class Categorydescription
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Items49
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items50 items { get; set; }
    }

    public class Items50
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsItemsDestinyderiveditemdefinition
    {
        public string description { get; set; }
        public Properties110 properties { get; set; }
    }

    public class Properties110
    {
        public Itemhash3 itemHash { get; set; }
        public Itemname itemName { get; set; }
        public Itemdetail itemDetail { get; set; }
        public Itemdescription itemDescription { get; set; }
        public Iconpath1 iconPath { get; set; }
        public Vendoritemindex vendorItemIndex { get; set; }
    }

    public class Itemhash3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemdetail
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemdescription
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Iconpath1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Vendoritemindex
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyvendordefinition
    {
        public string description { get; set; }
        public Properties111 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties111
    {
        public Displayproperties8 displayProperties { get; set; }
        public Buystring buyString { get; set; }
        public Sellstring sellString { get; set; }
        public Displayitemhash displayItemHash { get; set; }
        public Inhibitbuying inhibitBuying { get; set; }
        public Inhibitselling inhibitSelling { get; set; }
        public Factionhash1 factionHash { get; set; }
        public Resetintervalminutes resetIntervalMinutes { get; set; }
        public Resetoffsetminutes resetOffsetMinutes { get; set; }
        public Failurestrings failureStrings { get; set; }
        public Unlockranges unlockRanges { get; set; }
        public Vendoridentifier vendorIdentifier { get; set; }
        public Vendorportrait vendorPortrait { get; set; }
        public Vendorbanner vendorBanner { get; set; }
        public Enabled1 enabled { get; set; }
        public Visible1 visible { get; set; }
        public Vendorcategoryidentifier vendorCategoryIdentifier { get; set; }
        public Vendorsubcategoryidentifier vendorSubcategoryIdentifier { get; set; }
        public Consolidatecategories consolidateCategories { get; set; }
        public Actions actions { get; set; }
        public Categories categories { get; set; }
        public Originalcategories originalCategories { get; set; }
        public Displaycategories displayCategories { get; set; }
        public Interactions interactions { get; set; }
        public Inventoryflyouts inventoryFlyouts { get; set; }
        public Itemlist1 itemList { get; set; }
        public Services services { get; set; }
        public Accepteditems acceptedItems { get; set; }
        public Hash9 hash { get; set; }
        public Index9 index { get; set; }
        public Redacted9 redacted { get; set; }
    }

    public class Displayproperties8
    {
        public string _ref { get; set; }
    }

    public class Buystring
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Sellstring
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displayitemhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition24 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition24
    {
        public string _ref { get; set; }
    }

    public class Inhibitbuying
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Inhibitselling
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Factionhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition25 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition25
    {
        public string _ref { get; set; }
    }

    public class Resetintervalminutes
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Resetoffsetminutes
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Failurestrings
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items51 items { get; set; }
    }

    public class Items51
    {
        public string type { get; set; }
    }

    public class Unlockranges
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items52 items { get; set; }
    }

    public class Items52
    {
        public string _ref { get; set; }
    }

    public class Vendoridentifier
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Vendorportrait
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Vendorbanner
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Enabled1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Visible1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Vendorcategoryidentifier
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Vendorsubcategoryidentifier
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Consolidatecategories
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Actions
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items53 items { get; set; }
    }

    public class Items53
    {
        public string _ref { get; set; }
    }

    public class Categories
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items54 items { get; set; }
    }

    public class Items54
    {
        public string _ref { get; set; }
    }

    public class Originalcategories
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items55 items { get; set; }
    }

    public class Items55
    {
        public string _ref { get; set; }
    }

    public class Displaycategories
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items56 items { get; set; }
    }

    public class Items56
    {
        public string _ref { get; set; }
    }

    public class Interactions
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items57 items { get; set; }
    }

    public class Items57
    {
        public string _ref { get; set; }
    }

    public class Inventoryflyouts
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items58 items { get; set; }
    }

    public class Items58
    {
        public string _ref { get; set; }
    }

    public class Itemlist1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items59 items { get; set; }
    }

    public class Items59
    {
        public string _ref { get; set; }
    }

    public class Services
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items60 items { get; set; }
    }

    public class Items60
    {
        public string _ref { get; set; }
    }

    public class Accepteditems
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items61 items { get; set; }
    }

    public class Items61
    {
        public string _ref { get; set; }
    }

    public class Hash9
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index9
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted9
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyvendordisplaypropertiesdefinition
    {
        public Properties112 properties { get; set; }
    }

    public class Properties112
    {
        public Largeicon largeIcon { get; set; }
        public Subtitle subtitle { get; set; }
        public Requirementsdisplay requirementsDisplay { get; set; }
        public Description2 description { get; set; }
        public Name4 name { get; set; }
        public Icon3 icon { get; set; }
        public Hasicon2 hasIcon { get; set; }
    }

    public class Largeicon
    {
        public string type { get; set; }
    }

    public class Subtitle
    {
        public string type { get; set; }
    }

    public class Requirementsdisplay
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items62 items { get; set; }
    }

    public class Items62
    {
        public string _ref { get; set; }
    }

    public class Description2
    {
        public string type { get; set; }
    }

    public class Name4
    {
        public string type { get; set; }
    }

    public class Icon3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hasicon2
    {
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyvendorrequirementdisplayentrydefinition
    {
        public string description { get; set; }
        public Properties113 properties { get; set; }
    }

    public class Properties113
    {
        public Icon4 icon { get; set; }
        public Name5 name { get; set; }
        public Source1 source { get; set; }
        public Type type { get; set; }
    }

    public class Icon4
    {
        public string type { get; set; }
    }

    public class Name5
    {
        public string type { get; set; }
    }

    public class Source1
    {
        public string type { get; set; }
    }

    public class Type
    {
        public string type { get; set; }
    }

    public class DatesDaterange
    {
        public Properties114 properties { get; set; }
    }

    public class Properties114
    {
        public Start start { get; set; }
        public End end { get; set; }
    }

    public class Start
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class End
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyvendoractiondefinition
    {
        public string description { get; set; }
        public Properties115 properties { get; set; }
    }

    public class Properties115
    {
        public Description3 description { get; set; }
        public Executeseconds executeSeconds { get; set; }
        public Icon5 icon { get; set; }
        public Name6 name { get; set; }
        public Verb verb { get; set; }
        public Ispositive1 isPositive { get; set; }
        public Actionid actionId { get; set; }
        public Actionhash actionHash { get; set; }
        public Autoperformaction autoPerformAction { get; set; }
    }

    public class Description3
    {
        public string type { get; set; }
    }

    public class Executeseconds
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Icon5
    {
        public string type { get; set; }
    }

    public class Name6
    {
        public string type { get; set; }
    }

    public class Verb
    {
        public string type { get; set; }
    }

    public class Ispositive1
    {
        public string type { get; set; }
    }

    public class Actionid
    {
        public string type { get; set; }
    }

    public class Actionhash
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Autoperformaction
    {
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyvendorcategoryentrydefinition
    {
        public string description { get; set; }
        public Properties116 properties { get; set; }
    }

    public class Properties116
    {
        public Categoryindex categoryIndex { get; set; }
        public Categoryid categoryId { get; set; }
        public Categoryhash categoryHash { get; set; }
        public Quantityavailable quantityAvailable { get; set; }
        public Showunavailableitems showUnavailableItems { get; set; }
        public Hideifnocurrency hideIfNoCurrency { get; set; }
        public Hidefromregularpurchase hideFromRegularPurchase { get; set; }
        public Buystringoverride buyStringOverride { get; set; }
        public Disableddescription disabledDescription { get; set; }
        public Displaytitle displayTitle { get; set; }
        public Overlay overlay { get; set; }
    }

    public class Categoryindex
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Categoryid
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Categoryhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Quantityavailable
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Showunavailableitems
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hideifnocurrency
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hidefromregularpurchase
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Buystringoverride
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Disableddescription
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displaytitle
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Overlay
    {
        public string description { get; set; }
        public Allof37[] allOf { get; set; }
    }

    public class Allof37
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyvendorcategoryoverlaydefinition
    {
        public string description { get; set; }
        public Properties117 properties { get; set; }
    }

    public class Properties117
    {
        public Choicedescription choiceDescription { get; set; }
        public Description4 description { get; set; }
        public Icon6 icon { get; set; }
        public Title title { get; set; }
    }

    public class Choicedescription
    {
        public string type { get; set; }
    }

    public class Description4
    {
        public string type { get; set; }
    }

    public class Icon6
    {
        public string type { get; set; }
    }

    public class Title
    {
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinydisplaycategorydefinition
    {
        public string description { get; set; }
        public Properties118 properties { get; set; }
    }

    public class Properties118
    {
        public Identifier1 identifier { get; set; }
        public Displayproperties9 displayProperties { get; set; }
    }

    public class Identifier1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displayproperties9
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyvendorinteractiondefinition
    {
        public string description { get; set; }
        public Properties119 properties { get; set; }
    }

    public class Properties119
    {
        public Replies replies { get; set; }
        public Vendorcategoryindex vendorCategoryIndex { get; set; }
        public Questlineitemhash questlineItemHash { get; set; }
        public Sackinteractionlist sackInteractionList { get; set; }
        public Uiinteractiontype uiInteractionType { get; set; }
        public Rewardblocklabel rewardBlockLabel { get; set; }
        public Rewardvendorcategoryindex rewardVendorCategoryIndex { get; set; }
        public Flavorlineone flavorLineOne { get; set; }
        public Flavorlinetwo flavorLineTwo { get; set; }
        public Headerdisplayproperties headerDisplayProperties { get; set; }
        public Instructions instructions { get; set; }
    }

    public class Replies
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items63 items { get; set; }
    }

    public class Items63
    {
        public string _ref { get; set; }
    }

    public class Vendorcategoryindex
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Questlineitemhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition26 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition26
    {
        public string _ref { get; set; }
    }

    public class Sackinteractionlist
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items64 items { get; set; }
    }

    public class Items64
    {
        public string _ref { get; set; }
    }

    public class Uiinteractiontype
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Rewardblocklabel
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Rewardvendorcategoryindex
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Flavorlineone
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Flavorlinetwo
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Headerdisplayproperties
    {
        public string description { get; set; }
        public Allof38[] allOf { get; set; }
    }

    public class Allof38
    {
        public string _ref { get; set; }
    }

    public class Instructions
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyvendorinteractionreplydefinition
    {
        public string description { get; set; }
        public Properties120 properties { get; set; }
    }

    public class Properties120
    {
        public Itemrewardsselection itemRewardsSelection { get; set; }
        public Reply reply { get; set; }
        public Replytype replyType { get; set; }
    }

    public class Itemrewardsselection
    {
        public string description { get; set; }
        public Allof39[] allOf { get; set; }
    }

    public class Allof39
    {
        public string _ref { get; set; }
    }

    public class Reply
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Replytype
    {
        public string description { get; set; }
        public Allof40[] allOf { get; set; }
    }

    public class Allof40
    {
        public string _ref { get; set; }
    }

    public class DestinyDestinyvendorinteractionrewardselection
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues27[] xenumvalues { get; set; }
    }

    public class XEnumValues27
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDestinyvendorreplytype
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues28[] xenumvalues { get; set; }
    }

    public class XEnumValues28
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinyvendorinteractionsackentrydefinition
    {
        public string description { get; set; }
        public Properties121 properties { get; set; }
    }

    public class Properties121
    {
        public Sacktype sackType { get; set; }
    }

    public class Sacktype
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyvendorinventoryflyoutdefinition
    {
        public string description { get; set; }
        public Properties122 properties { get; set; }
    }

    public class Properties122
    {
        public Lockeddescription lockedDescription { get; set; }
        public Displayproperties10 displayProperties { get; set; }
        public Buckets buckets { get; set; }
        public Flyoutid flyoutId { get; set; }
        public Suppressnewness suppressNewness { get; set; }
    }

    public class Lockeddescription
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displayproperties10
    {
        public string description { get; set; }
        public Allof41[] allOf { get; set; }
    }

    public class Allof41
    {
        public string _ref { get; set; }
    }

    public class Buckets
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items65 items { get; set; }
    }

    public class Items65
    {
        public string _ref { get; set; }
    }

    public class Flyoutid
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Suppressnewness
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyvendorinventoryflyoutbucketdefinition
    {
        public string description { get; set; }
        public Properties123 properties { get; set; }
    }

    public class Properties123
    {
        public Collapsible collapsible { get; set; }
        public Inventorybuckethash inventoryBucketHash { get; set; }
        public Sortitemsby sortItemsBy { get; set; }
    }

    public class Collapsible
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Inventorybuckethash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition27 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition27
    {
        public string _ref { get; set; }
    }

    public class Sortitemsby
    {
        public string description { get; set; }
        public Allof42[] allOf { get; set; }
    }

    public class Allof42
    {
        public string _ref { get; set; }
    }

    public class DestinyDestinyitemsorttype
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues29[] xenumvalues { get; set; }
    }

    public class XEnumValues29
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinyvendoritemdefinition
    {
        public string description { get; set; }
        public Properties124 properties { get; set; }
    }

    public class Properties124
    {
        public Vendoritemindex1 vendorItemIndex { get; set; }
        public Itemhash4 itemHash { get; set; }
        public Quantity1 quantity { get; set; }
        public Failureindexes failureIndexes { get; set; }
        public Currencies currencies { get; set; }
        public Refundpolicy refundPolicy { get; set; }
        public Refundtimelimit refundTimeLimit { get; set; }
        public Creationlevels creationLevels { get; set; }
        public Displaycategoryindex displayCategoryIndex { get; set; }
        public Categoryindex1 categoryIndex { get; set; }
        public Originalcategoryindex originalCategoryIndex { get; set; }
        public Minimumlevel minimumLevel { get; set; }
        public Maximumlevel maximumLevel { get; set; }
        public Action1 action { get; set; }
        public Displaycategory displayCategory { get; set; }
        public Inventorybuckethash1 inventoryBucketHash { get; set; }
        public Visibilityscope visibilityScope { get; set; }
        public Purchasablescope purchasableScope { get; set; }
    }

    public class Vendoritemindex1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemhash4
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition28 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition28
    {
        public string _ref { get; set; }
    }

    public class Quantity1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Failureindexes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items66 items { get; set; }
    }

    public class Items66
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Currencies
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items67 items { get; set; }
    }

    public class Items67
    {
        public string _ref { get; set; }
    }

    public class Refundpolicy
    {
        public string description { get; set; }
        public Allof43[] allOf { get; set; }
    }

    public class Allof43
    {
        public string _ref { get; set; }
    }

    public class Refundtimelimit
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Creationlevels
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items68 items { get; set; }
    }

    public class Items68
    {
        public string _ref { get; set; }
    }

    public class Displaycategoryindex
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Categoryindex1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Originalcategoryindex
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Minimumlevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Maximumlevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Action1
    {
        public string description { get; set; }
        public Allof44[] allOf { get; set; }
    }

    public class Allof44
    {
        public string _ref { get; set; }
    }

    public class Displaycategory
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Inventorybuckethash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Visibilityscope
    {
        public string description { get; set; }
        public Allof45[] allOf { get; set; }
    }

    public class Allof45
    {
        public string _ref { get; set; }
    }

    public class Purchasablescope
    {
        public string description { get; set; }
        public Allof46[] allOf { get; set; }
    }

    public class Allof46
    {
        public string _ref { get; set; }
    }

    public class DestinyDestinyvendoritemrefundpolicy
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues30[] xenumvalues { get; set; }
    }

    public class XEnumValues30
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinyitemcreationentryleveldefinition
    {
        public string description { get; set; }
        public Properties125 properties { get; set; }
    }

    public class Properties125
    {
        public Level1 level { get; set; }
    }

    public class Level1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyvendorsaleitemactionblockdefinition
    {
        public string description { get; set; }
        public Properties126 properties { get; set; }
    }

    public class Properties126
    {
        public Executeseconds1 executeSeconds { get; set; }
        public Ispositive2 isPositive { get; set; }
    }

    public class Executeseconds1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Ispositive2
    {
        public string type { get; set; }
    }

    public class DestinyDestinygatingscope
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues31[] xenumvalues { get; set; }
    }

    public class XEnumValues31
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinyvendorservicedefinition
    {
        public string description { get; set; }
        public Properties127 properties { get; set; }
    }

    public class Properties127
    {
        public Name7 name { get; set; }
    }

    public class Name7
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyvendoraccepteditemdefinition
    {
        public string description { get; set; }
        public Properties128 properties { get; set; }
    }

    public class Properties128
    {
        public Acceptedinventorybuckethash acceptedInventoryBucketHash { get; set; }
        public Destinationinventorybuckethash destinationInventoryBucketHash { get; set; }
    }

    public class Acceptedinventorybuckethash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition29 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition29
    {
        public string _ref { get; set; }
    }

    public class Destinationinventorybuckethash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition30 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition30
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyfactiondefinition
    {
        public string description { get; set; }
        public Properties129 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties129
    {
        public Displayproperties11 displayProperties { get; set; }
        public Progressionhash1 progressionHash { get; set; }
        public Hash10 hash { get; set; }
        public Index10 index { get; set; }
        public Redacted10 redacted { get; set; }
    }

    public class Displayproperties11
    {
        public string _ref { get; set; }
    }

    public class Progressionhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition31 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition31
    {
        public string _ref { get; set; }
    }

    public class Hash10
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index10
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted10
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyitemqualityblockdefinition
    {
        public string description { get; set; }
        public Properties130 properties { get; set; }
    }

    public class Properties130
    {
        public Itemlevels itemLevels { get; set; }
        public Qualitylevel qualityLevel { get; set; }
        public Infusioncategoryname infusionCategoryName { get; set; }
        public Infusioncategoryhash infusionCategoryHash { get; set; }
        public Progressionlevelrequirementhash progressionLevelRequirementHash { get; set; }
    }

    public class Itemlevels
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items69 items { get; set; }
    }

    public class Items69
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Qualitylevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Infusioncategoryname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Infusioncategoryhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Progressionlevelrequirementhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition32 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition32
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsProgressionDestinyprogressionlevelrequirementdefinition
    {
        public string description { get; set; }
        public Properties131 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties131
    {
        public Requirementcurve requirementCurve { get; set; }
        public Progressionhash2 progressionHash { get; set; }
        public Hash11 hash { get; set; }
        public Index11 index { get; set; }
        public Redacted11 redacted { get; set; }
    }

    public class Requirementcurve
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items70 items { get; set; }
    }

    public class Items70
    {
        public string _ref { get; set; }
    }

    public class Progressionhash2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition33 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition33
    {
        public string _ref { get; set; }
    }

    public class Hash11
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index11
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted11
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class InterpolationInterpolationpointfloat
    {
        public Properties132 properties { get; set; }
    }

    public class Properties132
    {
        public Value3 value { get; set; }
        public Weight1 weight { get; set; }
    }

    public class Value3
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Weight1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyitemvalueblockdefinition
    {
        public string description { get; set; }
        public Properties133 properties { get; set; }
    }

    public class Properties133
    {
        public Itemvalue itemValue { get; set; }
        public Valuedescription valueDescription { get; set; }
    }

    public class Itemvalue
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items71 items { get; set; }
    }

    public class Items71
    {
        public string _ref { get; set; }
    }

    public class Valuedescription
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyitemsourceblockdefinition
    {
        public string description { get; set; }
        public Properties134 properties { get; set; }
    }

    public class Properties134
    {
        public Sourcehashes sourceHashes { get; set; }
        public Sources sources { get; set; }
        public Exclusive exclusive { get; set; }
    }

    public class Sourcehashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items72 items { get; set; }
        public XMappedDefinition34 xmappeddefinition { get; set; }
    }

    public class Items72
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition34
    {
        public string _ref { get; set; }
    }

    public class Sources
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items73 items { get; set; }
    }

    public class Items73
    {
        public string _ref { get; set; }
    }

    public class Exclusive
    {
        public string description { get; set; }
        public Allof47[] allOf { get; set; }
    }

    public class Allof47
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsSourcesDestinyitemsourcedefinition
    {
        public string description { get; set; }
        public Properties135 properties { get; set; }
    }

    public class Properties135
    {
        public Level2 level { get; set; }
        public Minquality minQuality { get; set; }
        public Maxquality maxQuality { get; set; }
        public Minlevelrequired minLevelRequired { get; set; }
        public Maxlevelrequired maxLevelRequired { get; set; }
        public Computedstats computedStats { get; set; }
        public Sourcehashes1 sourceHashes { get; set; }
    }

    public class Level2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Minquality
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Maxquality
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Minlevelrequired
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Maxlevelrequired
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Computedstats
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties72 additionalProperties { get; set; }
    }

    public class Additionalproperties72
    {
        public string _ref { get; set; }
    }

    public class Sourcehashes1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items74 items { get; set; }
        public XMappedDefinition35 xmappeddefinition { get; set; }
    }

    public class Items74
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition35
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyrewardsourcedefinition
    {
        public string description { get; set; }
        public Properties136 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties136
    {
        public Displayproperties12 displayProperties { get; set; }
        public Category1 category { get; set; }
        public Hash12 hash { get; set; }
        public Index12 index { get; set; }
        public Redacted12 redacted { get; set; }
    }

    public class Displayproperties12
    {
        public string _ref { get; set; }
    }

    public class Category1
    {
        public string description { get; set; }
        public Allof48[] allOf { get; set; }
    }

    public class Allof48
    {
        public string _ref { get; set; }
    }

    public class Hash12
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index12
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted12
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyrewardsourcecategory
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues32[] xenumvalues { get; set; }
    }

    public class XEnumValues32
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
    }

    public class DestinyDefinitionsDestinyitemobjectiveblockdefinition
    {
        public string description { get; set; }
        public Properties137 properties { get; set; }
    }

    public class Properties137
    {
        public Objectivehashes objectiveHashes { get; set; }
        public Displayactivityhashes displayActivityHashes { get; set; }
        public Requirefullobjectivecompletion requireFullObjectiveCompletion { get; set; }
        public Questlineitemhash1 questlineItemHash { get; set; }
        public Narrative narrative { get; set; }
        public Objectiveverbname objectiveVerbName { get; set; }
        public Questtypeidentifier questTypeIdentifier { get; set; }
        public Questtypehash questTypeHash { get; set; }
    }

    public class Objectivehashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items75 items { get; set; }
        public XMappedDefinition36 xmappeddefinition { get; set; }
    }

    public class Items75
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition36
    {
        public string _ref { get; set; }
    }

    public class Displayactivityhashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items76 items { get; set; }
        public XMappedDefinition37 xmappeddefinition { get; set; }
    }

    public class Items76
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition37
    {
        public string _ref { get; set; }
    }

    public class Requirefullobjectivecompletion
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Questlineitemhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition38 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition38
    {
        public string _ref { get; set; }
    }

    public class Narrative
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Objectiveverbname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Questtypeidentifier
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Questtypehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyobjectivedefinition
    {
        public string description { get; set; }
        public Properties138 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties138
    {
        public Displayproperties13 displayProperties { get; set; }
        public Completionvalue completionValue { get; set; }
        public Locationhash locationHash { get; set; }
        public Allownegativevalue allowNegativeValue { get; set; }
        public Allowvaluechangewhencompleted allowValueChangeWhenCompleted { get; set; }
        public Iscountingdownward isCountingDownward { get; set; }
        public Valuestyle valueStyle { get; set; }
        public Progressdescription progressDescription { get; set; }
        public Perks1 perks { get; set; }
        public Stats2 stats { get; set; }
        public Hash13 hash { get; set; }
        public Index13 index { get; set; }
        public Redacted13 redacted { get; set; }
    }

    public class Displayproperties13
    {
        public string description { get; set; }
        public Allof49[] allOf { get; set; }
    }

    public class Allof49
    {
        public string _ref { get; set; }
    }

    public class Completionvalue
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Locationhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition39 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition39
    {
        public string _ref { get; set; }
    }

    public class Allownegativevalue
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Allowvaluechangewhencompleted
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Iscountingdownward
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Valuestyle
    {
        public string description { get; set; }
        public Allof50[] allOf { get; set; }
    }

    public class Allof50
    {
        public string _ref { get; set; }
    }

    public class Progressdescription
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Perks1
    {
        public string description { get; set; }
        public Allof51[] allOf { get; set; }
    }

    public class Allof51
    {
        public string _ref { get; set; }
    }

    public class Stats2
    {
        public string description { get; set; }
        public Allof52[] allOf { get; set; }
    }

    public class Allof52
    {
        public string _ref { get; set; }
    }

    public class Hash13
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index13
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted13
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDestinyunlockvalueuistyle
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues33[] xenumvalues { get; set; }
    }

    public class XEnumValues33
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
    }

    public class DestinyDefinitionsDestinyobjectiveperkentrydefinition
    {
        public string description { get; set; }
        public Properties139 properties { get; set; }
    }

    public class Properties139
    {
        public Perkhash perkHash { get; set; }
        public Style style { get; set; }
    }

    public class Perkhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition40 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition40
    {
        public string _ref { get; set; }
    }

    public class Style
    {
        public string description { get; set; }
        public Allof53[] allOf { get; set; }
    }

    public class Allof53
    {
        public string _ref { get; set; }
    }

    public class DestinyDestinyobjectivegrantstyle
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues34[] xenumvalues { get; set; }
    }

    public class XEnumValues34
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinysandboxperkdefinition
    {
        public string description { get; set; }
        public Properties140 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties140
    {
        public Displayproperties14 displayProperties { get; set; }
        public Perkidentifier perkIdentifier { get; set; }
        public Isdisplayable isDisplayable { get; set; }
        public Damagetype damageType { get; set; }
        public Damagetypehash damageTypeHash { get; set; }
        public Perkgroups perkGroups { get; set; }
        public Hash14 hash { get; set; }
        public Index14 index { get; set; }
        public Redacted14 redacted { get; set; }
    }

    public class Displayproperties14
    {
        public string description { get; set; }
        public Allof54[] allOf { get; set; }
    }

    public class Allof54
    {
        public string _ref { get; set; }
    }

    public class Perkidentifier
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Isdisplayable
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Damagetype
    {
        public string description { get; set; }
        public Allof55[] allOf { get; set; }
    }

    public class Allof55
    {
        public string _ref { get; set; }
    }

    public class Damagetypehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Perkgroups
    {
        public string description { get; set; }
        public Allof56[] allOf { get; set; }
    }

    public class Allof56
    {
        public string _ref { get; set; }
    }

    public class Hash14
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index14
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted14
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDamagetype
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues35[] xenumvalues { get; set; }
    }

    public class XEnumValues35
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinytalentnodestepgroups
    {
        public string description { get; set; }
        public Properties141 properties { get; set; }
    }

    public class Properties141
    {
        public Weaponperformance weaponPerformance { get; set; }
        public Impacteffects impactEffects { get; set; }
        public Guardianattributes guardianAttributes { get; set; }
        public Lightabilities lightAbilities { get; set; }
        public Damagetypes1 damageTypes { get; set; }
    }

    public class Weaponperformance
    {
        public string _ref { get; set; }
    }

    public class Impacteffects
    {
        public string _ref { get; set; }
    }

    public class Guardianattributes
    {
        public string _ref { get; set; }
    }

    public class Lightabilities
    {
        public string _ref { get; set; }
    }

    public class Damagetypes1
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinytalentnodestepweaponperformances
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues36[] xenumvalues { get; set; }
    }

    public class XEnumValues36
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinytalentnodestepimpacteffects
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues37[] xenumvalues { get; set; }
    }

    public class XEnumValues37
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinytalentnodestepguardianattributes
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues38[] xenumvalues { get; set; }
    }

    public class XEnumValues38
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinytalentnodesteplightabilities
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues39[] xenumvalues { get; set; }
    }

    public class XEnumValues39
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinytalentnodestepdamagetypes
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues40[] xenumvalues { get; set; }
    }

    public class XEnumValues40
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinyobjectivestatentrydefinition
    {
        public string description { get; set; }
        public Properties142 properties { get; set; }
    }

    public class Properties142
    {
        public Stat stat { get; set; }
        public Style1 style { get; set; }
    }

    public class Stat
    {
        public string description { get; set; }
        public Allof57[] allOf { get; set; }
    }

    public class Allof57
    {
        public string _ref { get; set; }
    }

    public class Style1
    {
        public string description { get; set; }
        public Allof58[] allOf { get; set; }
    }

    public class Allof58
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyiteminvestmentstatdefinition
    {
        public string description { get; set; }
        public Properties143 properties { get; set; }
    }

    public class Properties143
    {
        public Stattypehash statTypeHash { get; set; }
        public Value4 value { get; set; }
    }

    public class Stattypehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition41 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition41
    {
        public string _ref { get; set; }
    }

    public class Value4
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinylocationdefinition
    {
        public string description { get; set; }
        public Properties144 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties144
    {
        public Vendorhash vendorHash { get; set; }
        public Locationreleases locationReleases { get; set; }
        public Hash15 hash { get; set; }
        public Index15 index { get; set; }
        public Redacted15 redacted { get; set; }
    }

    public class Vendorhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition42 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition42
    {
        public string _ref { get; set; }
    }

    public class Locationreleases
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items77 items { get; set; }
    }

    public class Items77
    {
        public string _ref { get; set; }
    }

    public class Hash15
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index15
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted15
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinylocationreleasedefinition
    {
        public string description { get; set; }
        public Properties145 properties { get; set; }
    }

    public class Properties145
    {
        public Displayproperties15 displayProperties { get; set; }
        public Spawnpoint spawnPoint { get; set; }
        public Destinationhash destinationHash { get; set; }
        public Activityhash activityHash { get; set; }
        public Activitygraphhash activityGraphHash { get; set; }
        public Activitygraphnodehash activityGraphNodeHash { get; set; }
        public Activitybubblename activityBubbleName { get; set; }
        public Activitypathbundle activityPathBundle { get; set; }
        public Activitypathdestination activityPathDestination { get; set; }
        public Navpointtype navPointType { get; set; }
        public Worldposition worldPosition { get; set; }
    }

    public class Displayproperties15
    {
        public string description { get; set; }
        public Allof59[] allOf { get; set; }
    }

    public class Allof59
    {
        public string _ref { get; set; }
    }

    public class Spawnpoint
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Destinationhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition43 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition43
    {
        public string _ref { get; set; }
    }

    public class Activityhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition44 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition44
    {
        public string _ref { get; set; }
    }

    public class Activitygraphhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Activitygraphnodehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Activitybubblename
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Activitypathbundle
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Activitypathdestination
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Navpointtype
    {
        public string description { get; set; }
        public Allof60[] allOf { get; set; }
    }

    public class Allof60
    {
        public string _ref { get; set; }
    }

    public class Worldposition
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items78 items { get; set; }
    }

    public class Items78
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDestinyactivitynavpointtype
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues41[] xenumvalues { get; set; }
    }

    public class XEnumValues41
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinydestinationdefinition
    {
        public string description { get; set; }
        public Properties146 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties146
    {
        public Displayproperties16 displayProperties { get; set; }
        public Placehash placeHash { get; set; }
        public Defaultfreeroamactivityhash defaultFreeroamActivityHash { get; set; }
        public Activitygraphentries activityGraphEntries { get; set; }
        public Bubblesettings bubbleSettings { get; set; }
        public Bubbles bubbles { get; set; }
        public Hash16 hash { get; set; }
        public Index16 index { get; set; }
        public Redacted16 redacted { get; set; }
    }

    public class Displayproperties16
    {
        public string _ref { get; set; }
    }

    public class Placehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition45 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition45
    {
        public string _ref { get; set; }
    }

    public class Defaultfreeroamactivityhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition46 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition46
    {
        public string _ref { get; set; }
    }

    public class Activitygraphentries
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items79 items { get; set; }
    }

    public class Items79
    {
        public string _ref { get; set; }
    }

    public class Bubblesettings
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items80 items { get; set; }
    }

    public class Items80
    {
        public string _ref { get; set; }
    }

    public class Bubbles
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items81 items { get; set; }
    }

    public class Items81
    {
        public string _ref { get; set; }
    }

    public class Hash16
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index16
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted16
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyactivitygraphlistentrydefinition
    {
        public string description { get; set; }
        public Properties147 properties { get; set; }
    }

    public class Properties147
    {
        public Activitygraphhash1 activityGraphHash { get; set; }
    }

    public class Activitygraphhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition47 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition47
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDirectorDestinyactivitygraphdefinition
    {
        public string description { get; set; }
        public Properties148 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties148
    {
        public Nodes nodes { get; set; }
        public Artelements artElements { get; set; }
        public Connections connections { get; set; }
        public Displayobjectives displayObjectives { get; set; }
        public Displayprogressions displayProgressions { get; set; }
        public Linkedgraphs linkedGraphs { get; set; }
        public Hash17 hash { get; set; }
        public Index17 index { get; set; }
        public Redacted17 redacted { get; set; }
    }

    public class Nodes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items82 items { get; set; }
    }

    public class Items82
    {
        public string _ref { get; set; }
    }

    public class Artelements
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items83 items { get; set; }
    }

    public class Items83
    {
        public string _ref { get; set; }
    }

    public class Connections
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items84 items { get; set; }
    }

    public class Items84
    {
        public string _ref { get; set; }
    }

    public class Displayobjectives
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items85 items { get; set; }
    }

    public class Items85
    {
        public string _ref { get; set; }
    }

    public class Displayprogressions
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items86 items { get; set; }
    }

    public class Items86
    {
        public string _ref { get; set; }
    }

    public class Linkedgraphs
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items87 items { get; set; }
    }

    public class Items87
    {
        public string _ref { get; set; }
    }

    public class Hash17
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index17
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted17
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDirectorDestinyactivitygraphnodedefinition
    {
        public string description { get; set; }
        public Properties149 properties { get; set; }
    }

    public class Properties149
    {
        public Nodeid nodeId { get; set; }
        public Overridedisplay overrideDisplay { get; set; }
        public Position position { get; set; }
        public Featuringstates featuringStates { get; set; }
        public Activities activities { get; set; }
    }

    public class Nodeid
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Overridedisplay
    {
        public string description { get; set; }
        public Allof61[] allOf { get; set; }
    }

    public class Allof61
    {
        public string _ref { get; set; }
    }

    public class Position
    {
        public string description { get; set; }
        public Allof62[] allOf { get; set; }
    }

    public class Allof62
    {
        public string _ref { get; set; }
    }

    public class Featuringstates
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items88 items { get; set; }
    }

    public class Items88
    {
        public string _ref { get; set; }
    }

    public class Activities
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items89 items { get; set; }
    }

    public class Items89
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsCommonDestinypositiondefinition
    {
        public Properties150 properties { get; set; }
    }

    public class Properties150
    {
        public X x { get; set; }
        public Y y { get; set; }
        public Z z { get; set; }
    }

    public class X
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Y
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Z
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDirectorDestinyactivitygraphnodefeaturingstatedefinition
    {
        public string description { get; set; }
        public Properties151 properties { get; set; }
    }

    public class Properties151
    {
        public Highlighttype highlightType { get; set; }
    }

    public class Highlighttype
    {
        public string description { get; set; }
        public Allof63[] allOf { get; set; }
    }

    public class Allof63
    {
        public string _ref { get; set; }
    }

    public class DestinyActivitygraphnodehighlighttype
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues42[] xenumvalues { get; set; }
    }

    public class XEnumValues42
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDirectorDestinyactivitygraphnodeactivitydefinition
    {
        public string description { get; set; }
        public Properties152 properties { get; set; }
    }

    public class Properties152
    {
        public Nodeactivityid nodeActivityId { get; set; }
        public Activityhash1 activityHash { get; set; }
    }

    public class Nodeactivityid
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Activityhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition48 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition48
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyactivitydefinition
    {
        public string description { get; set; }
        public Properties153 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties153
    {
        public Displayproperties17 displayProperties { get; set; }
        public Releaseicon releaseIcon { get; set; }
        public Releasetime releaseTime { get; set; }
        public Activitylevel activityLevel { get; set; }
        public Activitylightlevel activityLightLevel { get; set; }
        public Destinationhash1 destinationHash { get; set; }
        public Placehash1 placeHash { get; set; }
        public Activitytypehash activityTypeHash { get; set; }
        public Tier tier { get; set; }
        public Pgcrimage pgcrImage { get; set; }
        public Rewards rewards { get; set; }
        public Modifiers modifiers { get; set; }
        public Isplaylist isPlaylist { get; set; }
        public Challenges challenges { get; set; }
        public Optionalunlockstrings optionalUnlockStrings { get; set; }
        public Activitygraphlist activityGraphList { get; set; }
        public Matchmaking matchmaking { get; set; }
        public Guidedgame guidedGame { get; set; }
        public Activitymodehash activityModeHash { get; set; }
        public Ispvp isPvP { get; set; }
        public Hash18 hash { get; set; }
        public Index18 index { get; set; }
        public Redacted18 redacted { get; set; }
    }

    public class Displayproperties17
    {
        public string description { get; set; }
        public Allof64[] allOf { get; set; }
    }

    public class Allof64
    {
        public string _ref { get; set; }
    }

    public class Releaseicon
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Releasetime
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Activitylevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Activitylightlevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Destinationhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition49 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition49
    {
        public string _ref { get; set; }
    }

    public class Placehash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition50 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition50
    {
        public string _ref { get; set; }
    }

    public class Activitytypehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition51 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition51
    {
        public string _ref { get; set; }
    }

    public class Tier
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Pgcrimage
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Rewards
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items90 items { get; set; }
    }

    public class Items90
    {
        public string _ref { get; set; }
    }

    public class Modifiers
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items91 items { get; set; }
    }

    public class Items91
    {
        public string _ref { get; set; }
    }

    public class Isplaylist
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Challenges
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items92 items { get; set; }
    }

    public class Items92
    {
        public string _ref { get; set; }
    }

    public class Optionalunlockstrings
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items93 items { get; set; }
    }

    public class Items93
    {
        public string _ref { get; set; }
    }

    public class Activitygraphlist
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items94 items { get; set; }
    }

    public class Items94
    {
        public string _ref { get; set; }
    }

    public class Matchmaking
    {
        public string description { get; set; }
        public Allof65[] allOf { get; set; }
    }

    public class Allof65
    {
        public string _ref { get; set; }
    }

    public class Guidedgame
    {
        public string description { get; set; }
        public Allof66[] allOf { get; set; }
    }

    public class Allof66
    {
        public string _ref { get; set; }
    }

    public class Activitymodehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Ispvp
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hash18
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index18
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted18
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyactivityrewarddefinition
    {
        public string description { get; set; }
        public Properties154 properties { get; set; }
    }

    public class Properties154
    {
        public Rewardtext rewardText { get; set; }
        public Rewarditems1 rewardItems { get; set; }
    }

    public class Rewardtext
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Rewarditems1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items95 items { get; set; }
    }

    public class Items95
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyactivitymodifierreferencedefinition
    {
        public string description { get; set; }
        public Properties155 properties { get; set; }
    }

    public class Properties155
    {
        public Activitymodifierhash activityModifierHash { get; set; }
    }

    public class Activitymodifierhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition52 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition52
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsActivitymodifiersDestinyactivitymodifierdefinition
    {
        public string description { get; set; }
        public Properties156 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties156
    {
        public Displayproperties18 displayProperties { get; set; }
        public Hash19 hash { get; set; }
        public Index19 index { get; set; }
        public Redacted19 redacted { get; set; }
    }

    public class Displayproperties18
    {
        public string _ref { get; set; }
    }

    public class Hash19
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index19
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted19
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyactivitychallengedefinition
    {
        public string description { get; set; }
        public Properties157 properties { get; set; }
    }

    public class Properties157
    {
        public Objectivehash objectiveHash { get; set; }
    }

    public class Objectivehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition53 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition53
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyactivityunlockstringdefinition
    {
        public string description { get; set; }
        public Properties158 properties { get; set; }
    }

    public class Properties158
    {
        public Displaystring displayString { get; set; }
    }

    public class Displaystring
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyactivitymatchmakingblockdefinition
    {
        public string description { get; set; }
        public Properties159 properties { get; set; }
    }

    public class Properties159
    {
        public Ismatchmade isMatchmade { get; set; }
        public Minparty minParty { get; set; }
        public Maxparty maxParty { get; set; }
        public Maxplayers maxPlayers { get; set; }
        public Requiresguardianoath requiresGuardianOath { get; set; }
    }

    public class Ismatchmade
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Minparty
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Maxparty
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Maxplayers
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Requiresguardianoath
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyactivityguidedblockdefinition
    {
        public string description { get; set; }
        public Properties160 properties { get; set; }
    }

    public class Properties160
    {
        public Guidedmaxlobbysize guidedMaxLobbySize { get; set; }
        public Guidedminlobbysize guidedMinLobbySize { get; set; }
        public Guideddisbandcount guidedDisbandCount { get; set; }
    }

    public class Guidedmaxlobbysize
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Guidedminlobbysize
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Guideddisbandcount
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyplacedefinition
    {
        public string description { get; set; }
        public Properties161 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties161
    {
        public Displayproperties19 displayProperties { get; set; }
        public Hash20 hash { get; set; }
        public Index20 index { get; set; }
        public Redacted20 redacted { get; set; }
    }

    public class Displayproperties19
    {
        public string _ref { get; set; }
    }

    public class Hash20
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index20
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted20
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyactivitytypedefinition
    {
        public string description { get; set; }
        public Properties162 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties162
    {
        public Displayproperties20 displayProperties { get; set; }
        public Hash21 hash { get; set; }
        public Index21 index { get; set; }
        public Redacted21 redacted { get; set; }
    }

    public class Displayproperties20
    {
        public string _ref { get; set; }
    }

    public class Hash21
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index21
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted21
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDirectorDestinyactivitygraphartelementdefinition
    {
        public string description { get; set; }
        public Properties163 properties { get; set; }
    }

    public class Properties163
    {
        public Position1 position { get; set; }
    }

    public class Position1
    {
        public string description { get; set; }
        public Allof67[] allOf { get; set; }
    }

    public class Allof67
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDirectorDestinyactivitygraphconnectiondefinition
    {
        public string description { get; set; }
        public Properties164 properties { get; set; }
    }

    public class Properties164
    {
        public Sourcenodehash sourceNodeHash { get; set; }
        public Destnodehash destNodeHash { get; set; }
    }

    public class Sourcenodehash
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Destnodehash
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDirectorDestinyactivitygraphdisplayobjectivedefinition
    {
        public string description { get; set; }
        public Properties165 properties { get; set; }
    }

    public class Properties165
    {
        public Id id { get; set; }
        public Objectivehash1 objectiveHash { get; set; }
    }

    public class Id
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Objectivehash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition54 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition54
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDirectorDestinyactivitygraphdisplayprogressiondefinition
    {
        public string description { get; set; }
        public Properties166 properties { get; set; }
    }

    public class Properties166
    {
        public Id1 id { get; set; }
        public Progressionhash3 progressionHash { get; set; }
    }

    public class Id1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Progressionhash3
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDirectorDestinylinkedgraphdefinition
    {
        public string description { get; set; }
        public Properties167 properties { get; set; }
    }

    public class Properties167
    {
        public Description5 description { get; set; }
        public Name8 name { get; set; }
        public Unlockexpression unlockExpression { get; set; }
        public Linkedgraphid linkedGraphId { get; set; }
        public Linkedgraphs1 linkedGraphs { get; set; }
        public Overview overview { get; set; }
    }

    public class Description5
    {
        public string type { get; set; }
    }

    public class Name8
    {
        public string type { get; set; }
    }

    public class Unlockexpression
    {
        public string _ref { get; set; }
    }

    public class Linkedgraphid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Linkedgraphs1
    {
        public string type { get; set; }
        public Items96 items { get; set; }
    }

    public class Items96
    {
        public string _ref { get; set; }
    }

    public class Overview
    {
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyunlockexpressiondefinition
    {
        public string description { get; set; }
        public Properties168 properties { get; set; }
    }

    public class Properties168
    {
        public Scope2 scope { get; set; }
    }

    public class Scope2
    {
        public string description { get; set; }
        public Allof68[] allOf { get; set; }
    }

    public class Allof68
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDirectorDestinylinkedgraphentrydefinition
    {
        public Properties169 properties { get; set; }
    }

    public class Properties169
    {
        public Activitygraphhash2 activityGraphHash { get; set; }
    }

    public class Activitygraphhash2
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinydestinationbubblesettingdefinition
    {
        public string description { get; set; }
        public Properties170 properties { get; set; }
    }

    public class Properties170
    {
        public Displayproperties21 displayProperties { get; set; }
    }

    public class Displayproperties21
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinybubbledefinition
    {
        public string description { get; set; }
        public Properties171 properties { get; set; }
    }

    public class Properties171
    {
        public Hash22 hash { get; set; }
    }

    public class Hash22
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsItemsDestinyitemplugdefinition
    {
        public string description { get; set; }
        public Properties172 properties { get; set; }
    }

    public class Properties172
    {
        public Insertionrules insertionRules { get; set; }
        public Plugcategoryidentifier plugCategoryIdentifier { get; set; }
        public Plugcategoryhash plugCategoryHash { get; set; }
        public Onactionrecreateself onActionRecreateSelf { get; set; }
        public Insertionmaterialrequirementhash insertionMaterialRequirementHash { get; set; }
        public Previewitemoverridehash previewItemOverrideHash { get; set; }
        public Enabledmaterialrequirementhash enabledMaterialRequirementHash { get; set; }
        public Enabledrules enabledRules { get; set; }
    }

    public class Insertionrules
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items97 items { get; set; }
    }

    public class Items97
    {
        public string _ref { get; set; }
    }

    public class Plugcategoryidentifier
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Plugcategoryhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Onactionrecreateself
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Insertionmaterialrequirementhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition55 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition55
    {
        public string _ref { get; set; }
    }

    public class Previewitemoverridehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition56 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition56
    {
        public string _ref { get; set; }
    }

    public class Enabledmaterialrequirementhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition57 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition57
    {
        public string _ref { get; set; }
    }

    public class Enabledrules
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items98 items { get; set; }
    }

    public class Items98
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsItemsDestinyplugruledefinition
    {
        public string description { get; set; }
        public Properties173 properties { get; set; }
    }

    public class Properties173
    {
        public Failuremessage failureMessage { get; set; }
    }

    public class Failuremessage
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinymaterialrequirementsetdefinition
    {
        public string description { get; set; }
        public Properties174 properties { get; set; }
    }

    public class Properties174
    {
        public Materials materials { get; set; }
        public Hash23 hash { get; set; }
        public Index22 index { get; set; }
        public Redacted22 redacted { get; set; }
    }

    public class Materials
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items99 items { get; set; }
    }

    public class Items99
    {
        public string _ref { get; set; }
    }

    public class Hash23
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index22
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted22
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinymaterialrequirement
    {
        public string description { get; set; }
        public Properties175 properties { get; set; }
    }

    public class Properties175
    {
        public Itemhash5 itemHash { get; set; }
        public Deleteonaction2 deleteOnAction { get; set; }
        public Count1 count { get; set; }
        public Omitfromrequirements omitFromRequirements { get; set; }
    }

    public class Itemhash5
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition58 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition58
    {
        public string _ref { get; set; }
    }

    public class Deleteonaction2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Count1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Omitfromrequirements
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyitemgearsetblockdefinition
    {
        public string description { get; set; }
        public Properties176 properties { get; set; }
    }

    public class Properties176
    {
        public Trackingvaluemax trackingValueMax { get; set; }
        public Itemlist2 itemList { get; set; }
    }

    public class Trackingvaluemax
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemlist2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items100 items { get; set; }
        public XMappedDefinition59 xmappeddefinition { get; set; }
    }

    public class Items100
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition59
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyitemsackblockdefinition
    {
        public string description { get; set; }
        public Properties177 properties { get; set; }
    }

    public class Properties177
    {
        public Detailaction detailAction { get; set; }
        public Openaction openAction { get; set; }
        public Selectitemcount selectItemCount { get; set; }
        public Vendorsacktype vendorSackType { get; set; }
    }

    public class Detailaction
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Openaction
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Selectitemcount
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Vendorsacktype
    {
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyitemsocketblockdefinition
    {
        public string description { get; set; }
        public Properties178 properties { get; set; }
    }

    public class Properties178
    {
        public Detail1 detail { get; set; }
        public Socketentries socketEntries { get; set; }
        public Socketcategories socketCategories { get; set; }
    }

    public class Detail1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Socketentries
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items101 items { get; set; }
    }

    public class Items101
    {
        public string _ref { get; set; }
    }

    public class Socketcategories
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items102 items { get; set; }
    }

    public class Items102
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyitemsocketentrydefinition
    {
        public string description { get; set; }
        public Properties179 properties { get; set; }
    }

    public class Properties179
    {
        public Sockettypehash socketTypeHash { get; set; }
        public Singleinitialitemhash singleInitialItemHash { get; set; }
        public Reusableplugitems reusablePlugItems { get; set; }
    }

    public class Sockettypehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition60 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition60
    {
        public string _ref { get; set; }
    }

    public class Singleinitialitemhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition61 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition61
    {
        public string _ref { get; set; }
    }

    public class Reusableplugitems
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items103 items { get; set; }
    }

    public class Items103
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyitemsocketentryplugitemdefinition
    {
        public string description { get; set; }
        public Properties180 properties { get; set; }
    }

    public class Properties180
    {
        public Plugitemhash plugItemHash { get; set; }
    }

    public class Plugitemhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition62 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition62
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsSocketsDestinysockettypedefinition
    {
        public string description { get; set; }
        public Properties181 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties181
    {
        public Displayproperties22 displayProperties { get; set; }
        public Insertaction insertAction { get; set; }
        public Plugwhitelist plugWhitelist { get; set; }
        public Socketcategoryhash socketCategoryHash { get; set; }
        public Visibility visibility { get; set; }
        public Hash24 hash { get; set; }
        public Index23 index { get; set; }
        public Redacted23 redacted { get; set; }
    }

    public class Displayproperties22
    {
        public string description { get; set; }
        public Allof69[] allOf { get; set; }
    }

    public class Allof69
    {
        public string _ref { get; set; }
    }

    public class Insertaction
    {
        public string description { get; set; }
        public Allof70[] allOf { get; set; }
    }

    public class Allof70
    {
        public string _ref { get; set; }
    }

    public class Plugwhitelist
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items104 items { get; set; }
    }

    public class Items104
    {
        public string _ref { get; set; }
    }

    public class Socketcategoryhash
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Visibility
    {
        public string _ref { get; set; }
    }

    public class Hash24
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index23
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted23
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsSocketsDestinyinsertplugactiondefinition
    {
        public string description { get; set; }
        public Properties182 properties { get; set; }
    }

    public class Properties182
    {
        public Actionexecuteseconds actionExecuteSeconds { get; set; }
    }

    public class Actionexecuteseconds
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsSocketsDestinyplugwhitelistentrydefinition
    {
        public string description { get; set; }
        public Properties183 properties { get; set; }
    }

    public class Properties183
    {
        public Categoryhash1 categoryHash { get; set; }
        public Categoryidentifier categoryIdentifier { get; set; }
    }

    public class Categoryhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Categoryidentifier
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDestinysocketvisibility
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues43[] xenumvalues { get; set; }
    }

    public class XEnumValues43
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinyitemsocketcategorydefinition
    {
        public string description { get; set; }
        public Properties184 properties { get; set; }
    }

    public class Properties184
    {
        public Socketcategoryhash1 socketCategoryHash { get; set; }
        public Socketindexes socketIndexes { get; set; }
    }

    public class Socketcategoryhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition63 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition63
    {
        public string _ref { get; set; }
    }

    public class Socketindexes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items105 items { get; set; }
    }

    public class Items105
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyitemsummaryblockdefinition
    {
        public string description { get; set; }
        public Properties185 properties { get; set; }
    }

    public class Properties185
    {
        public Sortpriority sortPriority { get; set; }
    }

    public class Sortpriority
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyitemtalentgridblockdefinition
    {
        public string description { get; set; }
        public Properties186 properties { get; set; }
    }

    public class Properties186
    {
        public Talentgridhash talentGridHash { get; set; }
        public Itemdetailstring itemDetailString { get; set; }
        public Buildname buildName { get; set; }
        public Huddamagetype hudDamageType { get; set; }
        public Hudicon hudIcon { get; set; }
    }

    public class Talentgridhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition64 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition64
    {
        public string _ref { get; set; }
    }

    public class Itemdetailstring
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Buildname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Huddamagetype
    {
        public string description { get; set; }
        public Allof71[] allOf { get; set; }
    }

    public class Allof71
    {
        public string _ref { get; set; }
    }

    public class Hudicon
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinytalentgriddefinition
    {
        public string description { get; set; }
        public Properties187 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties187
    {
        public Maxgridlevel maxGridLevel { get; set; }
        public Gridlevelpercolumn gridLevelPerColumn { get; set; }
        public Progressionhash4 progressionHash { get; set; }
        public Nodes1 nodes { get; set; }
        public Exclusivesets exclusiveSets { get; set; }
        public Independentnodeindexes independentNodeIndexes { get; set; }
        public Groups1 groups { get; set; }
        public Nodecategories nodeCategories { get; set; }
        public Hash25 hash { get; set; }
        public Index24 index { get; set; }
        public Redacted24 redacted { get; set; }
    }

    public class Maxgridlevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Gridlevelpercolumn
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Progressionhash4
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition65 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition65
    {
        public string _ref { get; set; }
    }

    public class Nodes1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items106 items { get; set; }
    }

    public class Items106
    {
        public string _ref { get; set; }
    }

    public class Exclusivesets
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items107 items { get; set; }
    }

    public class Items107
    {
        public string _ref { get; set; }
    }

    public class Independentnodeindexes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items108 items { get; set; }
    }

    public class Items108
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Groups1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties73 additionalProperties { get; set; }
    }

    public class Additionalproperties73
    {
        public string _ref { get; set; }
    }

    public class Nodecategories
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items109 items { get; set; }
    }

    public class Items109
    {
        public string _ref { get; set; }
    }

    public class Hash25
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index24
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted24
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinytalentnodedefinition
    {
        public string description { get; set; }
        public Properties188 properties { get; set; }
    }

    public class Properties188
    {
        public Nodeindex nodeIndex { get; set; }
        public Nodehash nodeHash { get; set; }
        public Row row { get; set; }
        public Column column { get; set; }
        public Prerequisitenodeindexes prerequisiteNodeIndexes { get; set; }
        public Binarypairnodeindex binaryPairNodeIndex { get; set; }
        public Autounlocks autoUnlocks { get; set; }
        public Laststeprepeats lastStepRepeats { get; set; }
        public Israndom isRandom { get; set; }
        public Randomactivationrequirement randomActivationRequirement { get; set; }
        public Israndomrepurchasable isRandomRepurchasable { get; set; }
        public Steps1 steps { get; set; }
        public Exclusivewithnodehashes exclusiveWithNodeHashes { get; set; }
        public Randomstartprogressionbaratprogression randomStartProgressionBarAtProgression { get; set; }
        public Layoutidentifier layoutIdentifier { get; set; }
        public Grouphash groupHash { get; set; }
        public Lorehash1 loreHash { get; set; }
        public Nodestyleidentifier nodeStyleIdentifier { get; set; }
        public Ignoreforcompletion ignoreForCompletion { get; set; }
    }

    public class Nodeindex
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Nodehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Row
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Column
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Prerequisitenodeindexes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items110 items { get; set; }
    }

    public class Items110
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Binarypairnodeindex
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Autounlocks
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Laststeprepeats
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Israndom
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Randomactivationrequirement
    {
        public string description { get; set; }
        public Allof72[] allOf { get; set; }
    }

    public class Allof72
    {
        public string _ref { get; set; }
    }

    public class Israndomrepurchasable
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Steps1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items111 items { get; set; }
    }

    public class Items111
    {
        public string _ref { get; set; }
    }

    public class Exclusivewithnodehashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items112 items { get; set; }
    }

    public class Items112
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Randomstartprogressionbaratprogression
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Layoutidentifier
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Grouphash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Lorehash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition66 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition66
    {
        public string _ref { get; set; }
    }

    public class Nodestyleidentifier
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Ignoreforcompletion
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinynodeactivationrequirement
    {
        public string description { get; set; }
        public Properties189 properties { get; set; }
    }

    public class Properties189
    {
        public Gridlevel gridLevel { get; set; }
        public Materialrequirementhashes materialRequirementHashes { get; set; }
    }

    public class Gridlevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Materialrequirementhashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items113 items { get; set; }
        public XMappedDefinition67 xmappeddefinition { get; set; }
    }

    public class Items113
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition67
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinynodestepdefinition
    {
        public string description { get; set; }
        public Properties190 properties { get; set; }
    }

    public class Properties190
    {
        public Displayproperties23 displayProperties { get; set; }
        public Stepindex1 stepIndex { get; set; }
        public Nodestephash nodeStepHash { get; set; }
        public Interactiondescription interactionDescription { get; set; }
        public Damagetype1 damageType { get; set; }
        public Damagetypehash1 damageTypeHash { get; set; }
        public Activationrequirement activationRequirement { get; set; }
        public Canactivatenextstep canActivateNextStep { get; set; }
        public Nextstepindex nextStepIndex { get; set; }
        public Isnextsteprandom isNextStepRandom { get; set; }
        public Perkhashes perkHashes { get; set; }
        public Startprogressionbaratprogress startProgressionBarAtProgress { get; set; }
        public Stathashes statHashes { get; set; }
        public Affectsquality affectsQuality { get; set; }
        public Stepgroups stepGroups { get; set; }
        public Affectslevel affectsLevel { get; set; }
        public Socketreplacements socketReplacements { get; set; }
    }

    public class Displayproperties23
    {
        public string description { get; set; }
        public Allof73[] allOf { get; set; }
    }

    public class Allof73
    {
        public string _ref { get; set; }
    }

    public class Stepindex1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Nodestephash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Interactiondescription
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Damagetype1
    {
        public string description { get; set; }
        public Allof74[] allOf { get; set; }
    }

    public class Allof74
    {
        public string _ref { get; set; }
    }

    public class Damagetypehash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition68 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition68
    {
        public string _ref { get; set; }
    }

    public class Activationrequirement
    {
        public string description { get; set; }
        public Allof75[] allOf { get; set; }
    }

    public class Allof75
    {
        public string _ref { get; set; }
    }

    public class Canactivatenextstep
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Nextstepindex
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Isnextsteprandom
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Perkhashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items114 items { get; set; }
        public XMappedDefinition69 xmappeddefinition { get; set; }
    }

    public class Items114
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition69
    {
        public string _ref { get; set; }
    }

    public class Startprogressionbaratprogress
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Stathashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items115 items { get; set; }
        public XMappedDefinition70 xmappeddefinition { get; set; }
    }

    public class Items115
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition70
    {
        public string _ref { get; set; }
    }

    public class Affectsquality
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Stepgroups
    {
        public string description { get; set; }
        public Allof76[] allOf { get; set; }
    }

    public class Allof76
    {
        public string _ref { get; set; }
    }

    public class Affectslevel
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Socketreplacements
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items116 items { get; set; }
    }

    public class Items116
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinynodesocketreplaceresponse
    {
        public string description { get; set; }
        public Properties191 properties { get; set; }
    }

    public class Properties191
    {
        public Sockettypehash1 socketTypeHash { get; set; }
        public Plugitemhash1 plugItemHash { get; set; }
    }

    public class Sockettypehash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition71 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition71
    {
        public string _ref { get; set; }
    }

    public class Plugitemhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition72 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition72
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinydamagetypedefinition
    {
        public string description { get; set; }
        public Properties192 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties192
    {
        public Displayproperties24 displayProperties { get; set; }
        public Transparenticonpath transparentIconPath { get; set; }
        public Showicon showIcon { get; set; }
        public Enumvalue enumValue { get; set; }
        public Hash26 hash { get; set; }
        public Index25 index { get; set; }
        public Redacted25 redacted { get; set; }
    }

    public class Displayproperties24
    {
        public string description { get; set; }
        public Allof77[] allOf { get; set; }
    }

    public class Allof77
    {
        public string _ref { get; set; }
    }

    public class Transparenticonpath
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Showicon
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Enumvalue
    {
        public string description { get; set; }
        public Allof78[] allOf { get; set; }
    }

    public class Allof78
    {
        public string _ref { get; set; }
    }

    public class Hash26
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index25
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted25
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsLoreDestinyloredefinition
    {
        public string description { get; set; }
        public Properties193 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties193
    {
        public Displayproperties25 displayProperties { get; set; }
        public Subtitle1 subtitle { get; set; }
        public Hash27 hash { get; set; }
        public Index26 index { get; set; }
        public Redacted26 redacted { get; set; }
    }

    public class Displayproperties25
    {
        public string _ref { get; set; }
    }

    public class Subtitle1
    {
        public string type { get; set; }
    }

    public class Hash27
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index26
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted26
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinytalentnodeexclusivesetdefinition
    {
        public string description { get; set; }
        public Properties194 properties { get; set; }
    }

    public class Properties194
    {
        public Nodeindexes nodeIndexes { get; set; }
    }

    public class Nodeindexes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items117 items { get; set; }
    }

    public class Items117
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinytalentexclusivegroup
    {
        public string description { get; set; }
        public Properties195 properties { get; set; }
    }

    public class Properties195
    {
        public Grouphash1 groupHash { get; set; }
        public Lorehash2 loreHash { get; set; }
        public Nodehashes nodeHashes { get; set; }
        public Opposinggrouphashes opposingGroupHashes { get; set; }
        public Opposingnodehashes opposingNodeHashes { get; set; }
    }

    public class Grouphash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Lorehash2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition73 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition73
    {
        public string _ref { get; set; }
    }

    public class Nodehashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items118 items { get; set; }
    }

    public class Items118
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Opposinggrouphashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items119 items { get; set; }
    }

    public class Items119
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Opposingnodehashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items120 items { get; set; }
    }

    public class Items120
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinytalentnodecategory
    {
        public string description { get; set; }
        public Properties196 properties { get; set; }
    }

    public class Properties196
    {
        public Identifier2 identifier { get; set; }
        public Isloredriven isLoreDriven { get; set; }
        public Displayproperties26 displayProperties { get; set; }
        public Nodehashes1 nodeHashes { get; set; }
    }

    public class Identifier2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Isloredriven
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displayproperties26
    {
        public string description { get; set; }
        public Allof79[] allOf { get; set; }
    }

    public class Allof79
    {
        public string _ref { get; set; }
    }

    public class Nodehashes1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items121 items { get; set; }
    }

    public class Items121
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyitemperkentrydefinition
    {
        public string description { get; set; }
        public Properties197 properties { get; set; }
    }

    public class Properties197
    {
        public Requirementdisplaystring requirementDisplayString { get; set; }
        public Perkhash1 perkHash { get; set; }
    }

    public class Requirementdisplaystring
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Perkhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition74 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition74
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsAnimationsDestinyanimationreference
    {
        public Properties198 properties { get; set; }
    }

    public class Properties198
    {
        public Animname animName { get; set; }
        public Animidentifier animIdentifier { get; set; }
        public Path path { get; set; }
    }

    public class Animname
    {
        public string type { get; set; }
    }

    public class Animidentifier
    {
        public string type { get; set; }
    }

    public class Path
    {
        public string type { get; set; }
    }

    public class LinksHyperlinkreference
    {
        public Properties199 properties { get; set; }
    }

    public class Properties199
    {
        public Title1 title { get; set; }
        public Url url { get; set; }
    }

    public class Title1
    {
        public string type { get; set; }
    }

    public class Url
    {
        public string type { get; set; }
    }

    public class DestinySpecialitemtype
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues44[] xenumvalues { get; set; }
    }

    public class XEnumValues44
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDestinyitemtype
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues45[] xenumvalues { get; set; }
    }

    public class XEnumValues45
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDestinyitemsubtype
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues46[] xenumvalues { get; set; }
    }

    public class XEnumValues46
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDestinyclass
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues47[] xenumvalues { get; set; }
    }

    public class XEnumValues47
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinyitemcategorydefinition
    {
        public string description { get; set; }
        public Properties200 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties200
    {
        public Displayproperties27 displayProperties { get; set; }
        public Visible2 visible { get; set; }
        public Shorttitle shortTitle { get; set; }
        public Itemtyperegex itemTypeRegex { get; set; }
        public Itemtyperegexnot itemTypeRegexNot { get; set; }
        public Originbucketidentifier originBucketIdentifier { get; set; }
        public Grantdestinyitemtype grantDestinyItemType { get; set; }
        public Grantdestinysubtype grantDestinySubType { get; set; }
        public Grantdestinyclass grantDestinyClass { get; set; }
        public Groupedcategoryhashes groupedCategoryHashes { get; set; }
        public Hash28 hash { get; set; }
        public Index27 index { get; set; }
        public Redacted27 redacted { get; set; }
    }

    public class Displayproperties27
    {
        public string _ref { get; set; }
    }

    public class Visible2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Shorttitle
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemtyperegex
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemtyperegexnot
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Originbucketidentifier
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Grantdestinyitemtype
    {
        public string description { get; set; }
        public Allof80[] allOf { get; set; }
    }

    public class Allof80
    {
        public string _ref { get; set; }
    }

    public class Grantdestinysubtype
    {
        public string description { get; set; }
        public Allof81[] allOf { get; set; }
    }

    public class Allof81
    {
        public string _ref { get; set; }
    }

    public class Grantdestinyclass
    {
        public string description { get; set; }
        public Allof82[] allOf { get; set; }
    }

    public class Allof82
    {
        public string _ref { get; set; }
    }

    public class Groupedcategoryhashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items122 items { get; set; }
        public XMappedDefinition75 xmappeddefinition { get; set; }
    }

    public class Items122
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition75
    {
        public string _ref { get; set; }
    }

    public class Hash28
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index27
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted27
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Groupsv2Groupuserbase
    {
        public Properties201 properties { get; set; }
    }

    public class Properties201
    {
        public Groupid1 groupId { get; set; }
        public Destinyuserinfo destinyUserInfo { get; set; }
        public Bungienetuserinfo bungieNetUserInfo { get; set; }
        public Joindate joinDate { get; set; }
    }

    public class Groupid1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Destinyuserinfo
    {
        public string _ref { get; set; }
    }

    public class Bungienetuserinfo
    {
        public string _ref { get; set; }
    }

    public class Joindate
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Groupsv2Groupmember
    {
        public Properties202 properties { get; set; }
    }

    public class Properties202
    {
        public Membertype memberType { get; set; }
        public Isonline isOnline { get; set; }
        public Groupid2 groupId { get; set; }
        public Destinyuserinfo1 destinyUserInfo { get; set; }
        public Bungienetuserinfo1 bungieNetUserInfo { get; set; }
        public Joindate1 joinDate { get; set; }
    }

    public class Membertype
    {
        public string _ref { get; set; }
    }

    public class Isonline
    {
        public string type { get; set; }
    }

    public class Groupid2
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Destinyuserinfo1
    {
        public string _ref { get; set; }
    }

    public class Bungienetuserinfo1
    {
        public string _ref { get; set; }
    }

    public class Joindate1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Groupsv2Groupalliancestatus
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues48[] xenumvalues { get; set; }
    }

    public class XEnumValues48
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class Groupsv2Grouppotentialmember
    {
        public Properties203 properties { get; set; }
    }

    public class Properties203
    {
        public Potentialstatus potentialStatus { get; set; }
        public Groupid3 groupId { get; set; }
        public Destinyuserinfo2 destinyUserInfo { get; set; }
        public Bungienetuserinfo2 bungieNetUserInfo { get; set; }
        public Joindate2 joinDate { get; set; }
    }

    public class Potentialstatus
    {
        public string _ref { get; set; }
    }

    public class Groupid3
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Destinyuserinfo2
    {
        public string _ref { get; set; }
    }

    public class Bungienetuserinfo2
    {
        public string _ref { get; set; }
    }

    public class Joindate2
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Groupsv2Grouppotentialmemberstatus
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues49[] xenumvalues { get; set; }
    }

    public class XEnumValues49
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class TagsModelsContractsTagresponse
    {
        public Properties204 properties { get; set; }
    }

    public class Properties204
    {
        public Tagtext tagText { get; set; }
        public Ignorestatus2 ignoreStatus { get; set; }
    }

    public class Tagtext
    {
        public string type { get; set; }
    }

    public class Ignorestatus2
    {
        public string _ref { get; set; }
    }

    public class ForumPollresponse
    {
        public Properties205 properties { get; set; }
    }

    public class Properties205
    {
        public Topicid topicId { get; set; }
        public Results2 results { get; set; }
        public Totalvotes totalVotes { get; set; }
    }

    public class Topicid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Results2
    {
        public string type { get; set; }
        public Items123 items { get; set; }
    }

    public class Items123
    {
        public string _ref { get; set; }
    }

    public class Totalvotes
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class ForumPollresult
    {
        public Properties206 properties { get; set; }
    }

    public class Properties206
    {
        public Answertext answerText { get; set; }
        public Answerslot answerSlot { get; set; }
        public Lastvotedate lastVoteDate { get; set; }
        public Votes votes { get; set; }
        public Requestinguservoted requestingUserVoted { get; set; }
    }

    public class Answertext
    {
        public string type { get; set; }
    }

    public class Answerslot
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Lastvotedate
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Votes
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Requestinguservoted
    {
        public string type { get; set; }
    }

    public class ForumForumrecruitmentdetail
    {
        public Properties207 properties { get; set; }
    }

    public class Properties207
    {
        public Topicid1 topicId { get; set; }
        public Microphonerequired microphoneRequired { get; set; }
        public Intensity intensity { get; set; }
        public Tone tone { get; set; }
        public Approved approved { get; set; }
        public Conversationid1 conversationId { get; set; }
        public Playerslotstotal playerSlotsTotal { get; set; }
        public Playerslotsremaining playerSlotsRemaining { get; set; }
        public Fireteam Fireteam { get; set; }
        public Kickedplayerids kickedPlayerIds { get; set; }
    }

    public class Topicid1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Microphonerequired
    {
        public string type { get; set; }
    }

    public class Intensity
    {
        public string _ref { get; set; }
    }

    public class Tone
    {
        public string _ref { get; set; }
    }

    public class Approved
    {
        public string type { get; set; }
    }

    public class Conversationid1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Playerslotstotal
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Playerslotsremaining
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Fireteam
    {
        public string type { get; set; }
        public Items124 items { get; set; }
    }

    public class Items124
    {
        public string _ref { get; set; }
    }

    public class Kickedplayerids
    {
        public string type { get; set; }
        public Items125 items { get; set; }
    }

    public class Items125
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class ForumForumrecruitmentintensitylabel
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues50[] xenumvalues { get; set; }
    }

    public class XEnumValues50
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class ForumForumrecruitmenttonelabel
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues51[] xenumvalues { get; set; }
    }

    public class XEnumValues51
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class ForumForumpostsortenum
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues52[] xenumvalues { get; set; }
    }

    public class XEnumValues52
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class MessagesResponsesSavemessageresult
    {
        public Properties208 properties { get; set; }
    }

    public class Properties208
    {
        public Conversationid2 conversationId { get; set; }
        public Messageid messageId { get; set; }
    }

    public class Conversationid2
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Messageid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyConfigDestinymanifest
    {
        public string description { get; set; }
        public Properties209 properties { get; set; }
    }

    public class Properties209
    {
        public Version version { get; set; }
        public Mobileassetcontentpath mobileAssetContentPath { get; set; }
        public Mobilegearassetdatabases mobileGearAssetDataBases { get; set; }
        public Mobileworldcontentpaths mobileWorldContentPaths { get; set; }
        public Mobileclanbannerdatabasepath mobileClanBannerDatabasePath { get; set; }
        public Mobilegearcdn mobileGearCDN { get; set; }
    }

    public class Version
    {
        public string type { get; set; }
    }

    public class Mobileassetcontentpath
    {
        public string type { get; set; }
    }

    public class Mobilegearassetdatabases
    {
        public string type { get; set; }
        public Items126 items { get; set; }
    }

    public class Items126
    {
        public string _ref { get; set; }
    }

    public class Mobileworldcontentpaths
    {
        public string type { get; set; }
        public Additionalproperties74 additionalProperties { get; set; }
    }

    public class Additionalproperties74
    {
        public string type { get; set; }
    }

    public class Mobileclanbannerdatabasepath
    {
        public string type { get; set; }
    }

    public class Mobilegearcdn
    {
        public string type { get; set; }
        public Additionalproperties75 additionalProperties { get; set; }
    }

    public class Additionalproperties75
    {
        public string type { get; set; }
    }

    public class DestinyConfigGearassetdatabasedefinition
    {
        public Properties210 properties { get; set; }
    }

    public class Properties210
    {
        public Version1 version { get; set; }
        public Path1 path { get; set; }
    }

    public class Version1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Path1
    {
        public string type { get; set; }
    }

    public class DestinyDestinycomponenttype
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues53[] xenumvalues { get; set; }
    }

    public class XEnumValues53
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
    }

    public class DestinyResponsesDestinyprofileresponse
    {
        public string description { get; set; }
        public Properties211 properties { get; set; }
    }

    public class Properties211
    {
        public Vendorreceipts vendorReceipts { get; set; }
        public Profileinventory profileInventory { get; set; }
        public Profilecurrencies profileCurrencies { get; set; }
        public Profile profile { get; set; }
        public Profilekiosks profileKiosks { get; set; }
        public Characters characters { get; set; }
        public Characterinventories characterInventories { get; set; }
        public Characterprogressions characterProgressions { get; set; }
        public Characterrenderdata characterRenderData { get; set; }
        public Characteractivities characterActivities { get; set; }
        public Characterequipment characterEquipment { get; set; }
        public Characterkiosks characterKiosks { get; set; }
        public Itemcomponents itemComponents { get; set; }
    }

    public class Vendorreceipts
    {
        public string description { get; set; }
        public Allof83[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof83
    {
        public string _ref { get; set; }
    }

    public class Profileinventory
    {
        public string description { get; set; }
        public Allof84[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof84
    {
        public string _ref { get; set; }
    }

    public class Profilecurrencies
    {
        public string description { get; set; }
        public Allof85[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof85
    {
        public string _ref { get; set; }
    }

    public class Profile
    {
        public string description { get; set; }
        public Allof86[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof86
    {
        public string _ref { get; set; }
    }

    public class Profilekiosks
    {
        public string description { get; set; }
        public Allof87[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof87
    {
        public string _ref { get; set; }
    }

    public class Characters
    {
        public string description { get; set; }
        public Allof88[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof88
    {
        public string _ref { get; set; }
    }

    public class Characterinventories
    {
        public string description { get; set; }
        public Allof89[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof89
    {
        public string _ref { get; set; }
    }

    public class Characterprogressions
    {
        public string description { get; set; }
        public Allof90[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof90
    {
        public string _ref { get; set; }
    }

    public class Characterrenderdata
    {
        public string description { get; set; }
        public Allof91[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof91
    {
        public string _ref { get; set; }
    }

    public class Characteractivities
    {
        public string description { get; set; }
        public Allof92[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof92
    {
        public string _ref { get; set; }
    }

    public class Characterequipment
    {
        public string description { get; set; }
        public Allof93[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof93
    {
        public string _ref { get; set; }
    }

    public class Characterkiosks
    {
        public string description { get; set; }
        public Allof94[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof94
    {
        public string _ref { get; set; }
    }

    public class Itemcomponents
    {
        public string description { get; set; }
        public Allof95[] allOf { get; set; }
    }

    public class Allof95
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesProfilesDestinyvendorreceiptscomponent
    {
        public string description { get; set; }
        public Properties212 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties212
    {
        public Receipts receipts { get; set; }
    }

    public class Receipts
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items127 items { get; set; }
    }

    public class Items127
    {
        public string _ref { get; set; }
    }

    public class DestinyVendorsDestinyvendorreceipt
    {
        public string description { get; set; }
        public Properties213 properties { get; set; }
    }

    public class Properties213
    {
        public Currencypaid currencyPaid { get; set; }
        public Itemreceived itemReceived { get; set; }
        public Licenseunlockhash licenseUnlockHash { get; set; }
        public Purchasedbycharacterid purchasedByCharacterId { get; set; }
        public Refundpolicy1 refundPolicy { get; set; }
        public Sequencenumber sequenceNumber { get; set; }
        public Timetoexpiration timeToExpiration { get; set; }
        public Expireson expiresOn { get; set; }
    }

    public class Currencypaid
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items128 items { get; set; }
    }

    public class Items128
    {
        public string _ref { get; set; }
    }

    public class Itemreceived
    {
        public string description { get; set; }
        public Allof96[] allOf { get; set; }
    }

    public class Allof96
    {
        public string _ref { get; set; }
    }

    public class Licenseunlockhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Purchasedbycharacterid
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Refundpolicy1
    {
        public string description { get; set; }
        public Allof97[] allOf { get; set; }
    }

    public class Allof97
    {
        public string _ref { get; set; }
    }

    public class Sequencenumber
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Timetoexpiration
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Expireson
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class ComponentsComponentresponse
    {
        public string description { get; set; }
        public Properties214 properties { get; set; }
    }

    public class Properties214
    {
        public Privacy privacy { get; set; }
    }

    public class Privacy
    {
        public string _ref { get; set; }
    }

    public class ComponentsComponentprivacysetting
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues54[] xenumvalues { get; set; }
    }

    public class XEnumValues54
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class Singlecomponentresponseofdestinyvendorreceiptscomponent
    {
        public Properties215 properties { get; set; }
    }

    public class Properties215
    {
        public Data data { get; set; }
        public Privacy1 privacy { get; set; }
    }

    public class Data
    {
        public string _ref { get; set; }
    }

    public class Privacy1
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesInventoryDestinyinventorycomponent
    {
        public string description { get; set; }
        public Properties216 properties { get; set; }
    }

    public class Properties216
    {
        public Items129 items { get; set; }
    }

    public class Items129
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items130 items { get; set; }
    }

    public class Items130
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesItemsDestinyitemcomponent
    {
        public string description { get; set; }
        public Properties217 properties { get; set; }
    }

    public class Properties217
    {
        public Itemhash6 itemHash { get; set; }
        public Iteminstanceid1 itemInstanceId { get; set; }
        public Quantity2 quantity { get; set; }
        public Bindstatus bindStatus { get; set; }
        public Location1 location { get; set; }
        public Buckethash bucketHash { get; set; }
        public Transferstatus transferStatus { get; set; }
        public Lockable lockable { get; set; }
        public State state { get; set; }
    }

    public class Itemhash6
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition76 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition76
    {
        public string _ref { get; set; }
    }

    public class Iteminstanceid1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Quantity2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Bindstatus
    {
        public string description { get; set; }
        public Allof98[] allOf { get; set; }
    }

    public class Allof98
    {
        public string _ref { get; set; }
    }

    public class Location1
    {
        public string description { get; set; }
        public Allof99[] allOf { get; set; }
    }

    public class Allof99
    {
        public string _ref { get; set; }
    }

    public class Buckethash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition77 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition77
    {
        public string _ref { get; set; }
    }

    public class Transferstatus
    {
        public string description { get; set; }
        public Allof100[] allOf { get; set; }
    }

    public class Allof100
    {
        public string _ref { get; set; }
    }

    public class Lockable
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class State
    {
        public string description { get; set; }
        public Allof101[] allOf { get; set; }
    }

    public class Allof101
    {
        public string _ref { get; set; }
    }

    public class DestinyItembindstatus
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues55[] xenumvalues { get; set; }
    }

    public class XEnumValues55
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyTransferstatuses
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues56[] xenumvalues { get; set; }
    }

    public class XEnumValues56
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
    }

    public class DestinyItemstate
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues57[] xenumvalues { get; set; }
    }

    public class XEnumValues57
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class Singlecomponentresponseofdestinyinventorycomponent
    {
        public Properties218 properties { get; set; }
    }

    public class Properties218
    {
        public Data1 data { get; set; }
        public Privacy2 privacy { get; set; }
    }

    public class Data1
    {
        public string _ref { get; set; }
    }

    public class Privacy2
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesProfilesDestinyprofilecomponent
    {
        public string description { get; set; }
        public Properties219 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties219
    {
        public Userinfo userInfo { get; set; }
        public Datelastplayed dateLastPlayed { get; set; }
        public Versionsowned versionsOwned { get; set; }
        public Characterids characterIds { get; set; }
    }

    public class Userinfo
    {
        public string description { get; set; }
        public Allof102[] allOf { get; set; }
    }

    public class Allof102
    {
        public string _ref { get; set; }
    }

    public class Datelastplayed
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Versionsowned
    {
        public string description { get; set; }
        public Allof103[] allOf { get; set; }
    }

    public class Allof103
    {
        public string _ref { get; set; }
    }

    public class Characterids
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items131 items { get; set; }
    }

    public class Items131
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyDestinygameversions
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues58[] xenumvalues { get; set; }
    }

    public class XEnumValues58
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class Singlecomponentresponseofdestinyprofilecomponent
    {
        public Properties220 properties { get; set; }
    }

    public class Properties220
    {
        public Data2 data { get; set; }
        public Privacy3 privacy { get; set; }
    }

    public class Data2
    {
        public string _ref { get; set; }
    }

    public class Privacy3
    {
        public string _ref { get; set; }
    }

    public class DestinyComponentsKiosksDestinykioskscomponent
    {
        public string description { get; set; }
        public Properties221 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties221
    {
        public Kioskitems kioskItems { get; set; }
    }

    public class Kioskitems
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties76 additionalProperties { get; set; }
        public XMappedDefinition78 xmappeddefinition { get; set; }
    }

    public class Additionalproperties76
    {
        public string type { get; set; }
        public Items132 items { get; set; }
    }

    public class Items132
    {
        public string _ref { get; set; }
    }

    public class XMappedDefinition78
    {
        public string _ref { get; set; }
    }

    public class DestinyComponentsKiosksDestinykioskitem
    {
        public Properties222 properties { get; set; }
    }

    public class Properties222
    {
        public Index28 index { get; set; }
        public Canacquire canAcquire { get; set; }
        public Failureindexes1 failureIndexes { get; set; }
    }

    public class Index28
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canacquire
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Failureindexes1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items133 items { get; set; }
    }

    public class Items133
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Singlecomponentresponseofdestinykioskscomponent
    {
        public Properties223 properties { get; set; }
    }

    public class Properties223
    {
        public Data3 data { get; set; }
        public Privacy4 privacy { get; set; }
    }

    public class Data3
    {
        public string _ref { get; set; }
    }

    public class Privacy4
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesCharactersDestinycharactercomponent
    {
        public string description { get; set; }
        public Properties224 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties224
    {
        public Membershipid3 membershipId { get; set; }
        public Membershiptype2 membershipType { get; set; }
        public Characterid characterId { get; set; }
        public Datelastplayed1 dateLastPlayed { get; set; }
        public Minutesplayedthissession minutesPlayedThisSession { get; set; }
        public Minutesplayedtotal minutesPlayedTotal { get; set; }
        public Light light { get; set; }
        public Stats3 stats { get; set; }
        public Racehash raceHash { get; set; }
        public Genderhash genderHash { get; set; }
        public Classhash1 classHash { get; set; }
        public Racetype raceType { get; set; }
        public Classtype1 classType { get; set; }
        public Gendertype genderType { get; set; }
        public Emblempath emblemPath { get; set; }
        public Emblembackgroundpath emblemBackgroundPath { get; set; }
        public Emblemhash emblemHash { get; set; }
        public Levelprogression levelProgression { get; set; }
        public Basecharacterlevel baseCharacterLevel { get; set; }
        public Percenttonextlevel percentToNextLevel { get; set; }
    }

    public class Membershipid3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Membershiptype2
    {
        public string description { get; set; }
        public Allof104[] allOf { get; set; }
    }

    public class Allof104
    {
        public string _ref { get; set; }
    }

    public class Characterid
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Datelastplayed1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Minutesplayedthissession
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Minutesplayedtotal
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Light
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Stats3
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties77 additionalProperties { get; set; }
    }

    public class Additionalproperties77
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Racehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition79 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition79
    {
        public string _ref { get; set; }
    }

    public class Genderhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition80 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition80
    {
        public string _ref { get; set; }
    }

    public class Classhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition81 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition81
    {
        public string _ref { get; set; }
    }

    public class Racetype
    {
        public string description { get; set; }
        public Allof105[] allOf { get; set; }
    }

    public class Allof105
    {
        public string _ref { get; set; }
    }

    public class Classtype1
    {
        public string description { get; set; }
        public Allof106[] allOf { get; set; }
    }

    public class Allof106
    {
        public string _ref { get; set; }
    }

    public class Gendertype
    {
        public string description { get; set; }
        public Allof107[] allOf { get; set; }
    }

    public class Allof107
    {
        public string _ref { get; set; }
    }

    public class Emblempath
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Emblembackgroundpath
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Emblemhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition82 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition82
    {
        public string _ref { get; set; }
    }

    public class Levelprogression
    {
        public string description { get; set; }
        public Allof108[] allOf { get; set; }
    }

    public class Allof108
    {
        public string _ref { get; set; }
    }

    public class Basecharacterlevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Percenttonextlevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDestinyrace
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues59[] xenumvalues { get; set; }
    }

    public class XEnumValues59
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDestinygender
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues60[] xenumvalues { get; set; }
    }

    public class XEnumValues60
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinyracedefinition
    {
        public string description { get; set; }
        public Properties225 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties225
    {
        public Displayproperties28 displayProperties { get; set; }
        public Racetype1 raceType { get; set; }
        public Genderedracenames genderedRaceNames { get; set; }
        public Hash29 hash { get; set; }
        public Index29 index { get; set; }
        public Redacted28 redacted { get; set; }
    }

    public class Displayproperties28
    {
        public string _ref { get; set; }
    }

    public class Racetype1
    {
        public string description { get; set; }
        public Allof109[] allOf { get; set; }
    }

    public class Allof109
    {
        public string _ref { get; set; }
    }

    public class Genderedracenames
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties78 additionalProperties { get; set; }
    }

    public class Additionalproperties78
    {
        public string type { get; set; }
    }

    public class Hash29
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index29
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted28
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinygenderdefinition
    {
        public string description { get; set; }
        public Properties226 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties226
    {
        public Gendertype1 genderType { get; set; }
        public Displayproperties29 displayProperties { get; set; }
        public Hash30 hash { get; set; }
        public Index30 index { get; set; }
        public Redacted29 redacted { get; set; }
    }

    public class Gendertype1
    {
        public string description { get; set; }
        public Allof110[] allOf { get; set; }
    }

    public class Allof110
    {
        public string _ref { get; set; }
    }

    public class Displayproperties29
    {
        public string _ref { get; set; }
    }

    public class Hash30
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index30
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted29
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsDestinyclassdefinition
    {
        public string description { get; set; }
        public Properties227 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties227
    {
        public Classtype2 classType { get; set; }
        public Displayproperties30 displayProperties { get; set; }
        public Genderedclassnames genderedClassNames { get; set; }
        public Mentorvendorhash mentorVendorHash { get; set; }
        public Hash31 hash { get; set; }
        public Index31 index { get; set; }
        public Redacted30 redacted { get; set; }
    }

    public class Classtype2
    {
        public string description { get; set; }
        public Allof111[] allOf { get; set; }
    }

    public class Allof111
    {
        public string _ref { get; set; }
    }

    public class Displayproperties30
    {
        public string _ref { get; set; }
    }

    public class Genderedclassnames
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties79 additionalProperties { get; set; }
    }

    public class Additionalproperties79
    {
        public string type { get; set; }
    }

    public class Mentorvendorhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition83 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition83
    {
        public string _ref { get; set; }
    }

    public class Hash31
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index31
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted30
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Dictionarycomponentresponseofint64anddestinycharactercomponent
    {
        public Properties228 properties { get; set; }
    }

    public class Properties228
    {
        public Data4 data { get; set; }
        public Privacy5 privacy { get; set; }
    }

    public class Data4
    {
        public string type { get; set; }
        public Additionalproperties80 additionalProperties { get; set; }
    }

    public class Additionalproperties80
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy5
    {
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint64anddestinyinventorycomponent
    {
        public Properties229 properties { get; set; }
    }

    public class Properties229
    {
        public Data5 data { get; set; }
        public Privacy6 privacy { get; set; }
    }

    public class Data5
    {
        public string type { get; set; }
        public Additionalproperties81 additionalProperties { get; set; }
    }

    public class Additionalproperties81
    {
        public string _ref { get; set; }
    }

    public class Privacy6
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesCharactersDestinycharacterprogressioncomponent
    {
        public string description { get; set; }
        public Properties230 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties230
    {
        public Progressions progressions { get; set; }
        public Factions factions { get; set; }
        public Milestones milestones { get; set; }
        public Quests quests { get; set; }
        public Uninstanceditemobjectives uninstancedItemObjectives { get; set; }
    }

    public class Progressions
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties82 additionalProperties { get; set; }
        public XMappedDefinition84 xmappeddefinition { get; set; }
    }

    public class Additionalproperties82
    {
        public string _ref { get; set; }
    }

    public class XMappedDefinition84
    {
        public string _ref { get; set; }
    }

    public class Factions
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties83 additionalProperties { get; set; }
        public XMappedDefinition85 xmappeddefinition { get; set; }
    }

    public class Additionalproperties83
    {
        public string _ref { get; set; }
    }

    public class XMappedDefinition85
    {
        public string _ref { get; set; }
    }

    public class Milestones
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties84 additionalProperties { get; set; }
        public XMappedDefinition86 xmappeddefinition { get; set; }
    }

    public class Additionalproperties84
    {
        public string _ref { get; set; }
    }

    public class XMappedDefinition86
    {
        public string _ref { get; set; }
    }

    public class Quests
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items134 items { get; set; }
    }

    public class Items134
    {
        public string _ref { get; set; }
    }

    public class Uninstanceditemobjectives
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties85 additionalProperties { get; set; }
        public XMappedDefinition87 xmappeddefinition { get; set; }
    }

    public class Additionalproperties85
    {
        public string type { get; set; }
        public Items135 items { get; set; }
    }

    public class Items135
    {
        public string _ref { get; set; }
    }

    public class XMappedDefinition87
    {
        public string _ref { get; set; }
    }

    public class DestinyProgressionDestinyfactionprogression
    {
        public string description { get; set; }
        public Properties231 properties { get; set; }
    }

    public class Properties231
    {
        public Factionhash2 factionHash { get; set; }
        public Progressionhash5 progressionHash { get; set; }
        public Dailyprogress1 dailyProgress { get; set; }
        public Dailylimit1 dailyLimit { get; set; }
        public Weeklyprogress1 weeklyProgress { get; set; }
        public Weeklylimit1 weeklyLimit { get; set; }
        public Currentprogress1 currentProgress { get; set; }
        public Level3 level { get; set; }
        public Levelcap1 levelCap { get; set; }
        public Stepindex2 stepIndex { get; set; }
        public Progresstonextlevel1 progressToNextLevel { get; set; }
        public Nextlevelat1 nextLevelAt { get; set; }
    }

    public class Factionhash2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition88 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition88
    {
        public string _ref { get; set; }
    }

    public class Progressionhash5
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition89 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition89
    {
        public string _ref { get; set; }
    }

    public class Dailyprogress1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Dailylimit1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Weeklyprogress1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Weeklylimit1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Currentprogress1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Level3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Levelcap1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Stepindex2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Progresstonextlevel1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Nextlevelat1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyMilestonesDestinymilestone
    {
        public string description { get; set; }
        public Properties232 properties { get; set; }
    }

    public class Properties232
    {
        public Milestonehash milestoneHash { get; set; }
        public Availablequests availableQuests { get; set; }
        public Values values { get; set; }
        public Vendorhashes vendorHashes { get; set; }
        public Rewards1 rewards { get; set; }
        public Startdate startDate { get; set; }
        public Enddate endDate { get; set; }
    }

    public class Milestonehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition90 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition90
    {
        public string _ref { get; set; }
    }

    public class Availablequests
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items136 items { get; set; }
    }

    public class Items136
    {
        public string _ref { get; set; }
    }

    public class Values
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties86 additionalProperties { get; set; }
    }

    public class Additionalproperties86
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Vendorhashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items137 items { get; set; }
        public XMappedDefinition91 xmappeddefinition { get; set; }
    }

    public class Items137
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition91
    {
        public string _ref { get; set; }
    }

    public class Rewards1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items138 items { get; set; }
    }

    public class Items138
    {
        public string _ref { get; set; }
    }

    public class Startdate
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Enddate
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyMilestonesDestinymilestonequest
    {
        public string description { get; set; }
        public Properties233 properties { get; set; }
    }

    public class Properties233
    {
        public Questitemhash questItemHash { get; set; }
        public Status status { get; set; }
        public Activity activity { get; set; }
        public Challenges1 challenges { get; set; }
    }

    public class Questitemhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition92 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition92
    {
        public string _ref { get; set; }
    }

    public class Status
    {
        public string description { get; set; }
        public Allof112[] allOf { get; set; }
    }

    public class Allof112
    {
        public string _ref { get; set; }
    }

    public class Activity
    {
        public string description { get; set; }
        public Allof113[] allOf { get; set; }
    }

    public class Allof113
    {
        public string _ref { get; set; }
    }

    public class Challenges1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items139 items { get; set; }
    }

    public class Items139
    {
        public string _ref { get; set; }
    }

    public class DestinyQuestsDestinyqueststatus
    {
        public string description { get; set; }
        public Properties234 properties { get; set; }
    }

    public class Properties234
    {
        public Questhash questHash { get; set; }
        public Stephash stepHash { get; set; }
        public Stepobjectives stepObjectives { get; set; }
        public Tracked tracked { get; set; }
        public Iteminstanceid2 itemInstanceId { get; set; }
        public Completed completed { get; set; }
        public Redeemed redeemed { get; set; }
        public Started started { get; set; }
        public Vendorhash1 vendorHash { get; set; }
    }

    public class Questhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition93 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition93
    {
        public string _ref { get; set; }
    }

    public class Stephash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition94 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition94
    {
        public string _ref { get; set; }
    }

    public class Stepobjectives
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items140 items { get; set; }
    }

    public class Items140
    {
        public string _ref { get; set; }
    }

    public class Tracked
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Iteminstanceid2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Completed
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redeemed
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Started
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Vendorhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyQuestsDestinyobjectiveprogress
    {
        public string description { get; set; }
        public Properties235 properties { get; set; }
    }

    public class Properties235
    {
        public Objectivehash2 objectiveHash { get; set; }
        public Destinationhash2 destinationHash { get; set; }
        public Activityhash2 activityHash { get; set; }
        public Progress progress { get; set; }
        public Complete complete { get; set; }
    }

    public class Objectivehash2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition95 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition95
    {
        public string _ref { get; set; }
    }

    public class Destinationhash2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition96 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition96
    {
        public string _ref { get; set; }
    }

    public class Activityhash2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition97 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition97
    {
        public string _ref { get; set; }
    }

    public class Progress
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Complete
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyMilestonesDestinymilestoneactivity
    {
        public string description { get; set; }
        public Properties236 properties { get; set; }
    }

    public class Properties236
    {
        public Activityhash3 activityHash { get; set; }
        public Modifierhashes modifierHashes { get; set; }
        public Variants variants { get; set; }
    }

    public class Activityhash3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition98 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition98
    {
        public string _ref { get; set; }
    }

    public class Modifierhashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items141 items { get; set; }
        public XMappedDefinition99 xmappeddefinition { get; set; }
    }

    public class Items141
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition99
    {
        public string _ref { get; set; }
    }

    public class Variants
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items142 items { get; set; }
    }

    public class Items142
    {
        public string _ref { get; set; }
    }

    public class DestinyMilestonesDestinymilestoneactivityvariant
    {
        public string description { get; set; }
        public Properties237 properties { get; set; }
    }

    public class Properties237
    {
        public Activityhash4 activityHash { get; set; }
        public Completionstatus completionStatus { get; set; }
    }

    public class Activityhash4
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition100 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition100
    {
        public string _ref { get; set; }
    }

    public class Completionstatus
    {
        public string description { get; set; }
        public Allof114[] allOf { get; set; }
    }

    public class Allof114
    {
        public string _ref { get; set; }
    }

    public class DestinyMilestonesDestinymilestoneactivitycompletionstatus
    {
        public string description { get; set; }
        public Properties238 properties { get; set; }
    }

    public class Properties238
    {
        public Completed1 completed { get; set; }
        public Phases phases { get; set; }
    }

    public class Completed1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Phases
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items143 items { get; set; }
    }

    public class Items143
    {
        public string _ref { get; set; }
    }

    public class DestinyMilestonesDestinymilestoneactivityphase
    {
        public string description { get; set; }
        public Properties239 properties { get; set; }
    }

    public class Properties239
    {
        public Complete1 complete { get; set; }
    }

    public class Complete1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyChallengesDestinychallengestatus
    {
        public string description { get; set; }
        public Properties240 properties { get; set; }
    }

    public class Properties240
    {
        public Objective objective { get; set; }
    }

    public class Objective
    {
        public string description { get; set; }
        public Allof115[] allOf { get; set; }
    }

    public class Allof115
    {
        public string _ref { get; set; }
    }

    public class DestinyMilestonesDestinymilestonerewardcategory
    {
        public string description { get; set; }
        public Properties241 properties { get; set; }
    }

    public class Properties241
    {
        public Rewardcategoryhash rewardCategoryHash { get; set; }
        public Entries entries { get; set; }
    }

    public class Rewardcategoryhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Entries
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items144 items { get; set; }
    }

    public class Items144
    {
        public string _ref { get; set; }
    }

    public class DestinyMilestonesDestinymilestonerewardentry
    {
        public string description { get; set; }
        public Properties242 properties { get; set; }
    }

    public class Properties242
    {
        public Rewardentryhash rewardEntryHash { get; set; }
        public Earned earned { get; set; }
        public Redeemed1 redeemed { get; set; }
    }

    public class Rewardentryhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Earned
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redeemed1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsMilestonesDestinymilestonedefinition
    {
        public string description { get; set; }
        public Properties243 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties243
    {
        public Displayproperties31 displayProperties { get; set; }
        public Image image { get; set; }
        public Milestonetype milestoneType { get; set; }
        public Recruitable recruitable { get; set; }
        public Friendlyname friendlyName { get; set; }
        public Showinexplorer showInExplorer { get; set; }
        public Haspredictabledates hasPredictableDates { get; set; }
        public Quests1 quests { get; set; }
        public Rewards2 rewards { get; set; }
        public Vendors vendors { get; set; }
        public Values1 values { get; set; }
        public Isingamemilestone isInGameMilestone { get; set; }
        public Hash32 hash { get; set; }
        public Index32 index { get; set; }
        public Redacted31 redacted { get; set; }
    }

    public class Displayproperties31
    {
        public string _ref { get; set; }
    }

    public class Image
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Milestonetype
    {
        public string description { get; set; }
        public Allof116[] allOf { get; set; }
    }

    public class Allof116
    {
        public string _ref { get; set; }
    }

    public class Recruitable
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Friendlyname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Showinexplorer
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Haspredictabledates
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Quests1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties87 additionalProperties { get; set; }
    }

    public class Additionalproperties87
    {
        public string _ref { get; set; }
    }

    public class Rewards2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties88 additionalProperties { get; set; }
    }

    public class Additionalproperties88
    {
        public string _ref { get; set; }
    }

    public class Vendors
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items145 items { get; set; }
    }

    public class Items145
    {
        public string _ref { get; set; }
    }

    public class Values1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties89 additionalProperties { get; set; }
    }

    public class Additionalproperties89
    {
        public string _ref { get; set; }
    }

    public class Isingamemilestone
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hash32
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index32
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted31
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsMilestonesDestinymilestonetype
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues61[] xenumvalues { get; set; }
    }

    public class XEnumValues61
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
    }

    public class DestinyDefinitionsMilestonesDestinymilestonequestdefinition
    {
        public string description { get; set; }
        public Properties244 properties { get; set; }
    }

    public class Properties244
    {
        public Questitemhash1 questItemHash { get; set; }
        public Displayproperties32 displayProperties { get; set; }
        public Overrideimage overrideImage { get; set; }
        public Questrewards questRewards { get; set; }
        public Activities1 activities { get; set; }
    }

    public class Questitemhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition101 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition101
    {
        public string _ref { get; set; }
    }

    public class Displayproperties32
    {
        public string description { get; set; }
        public Allof117[] allOf { get; set; }
    }

    public class Allof117
    {
        public string _ref { get; set; }
    }

    public class Overrideimage
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Questrewards
    {
        public string description { get; set; }
        public Allof118[] allOf { get; set; }
    }

    public class Allof118
    {
        public string _ref { get; set; }
    }

    public class Activities1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties90 additionalProperties { get; set; }
        public XMappedDefinition102 xmappeddefinition { get; set; }
    }

    public class Additionalproperties90
    {
        public string _ref { get; set; }
    }

    public class XMappedDefinition102
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsMilestonesDestinymilestonequestrewardsdefinition
    {
        public string description { get; set; }
        public Properties245 properties { get; set; }
    }

    public class Properties245
    {
        public Items146 items { get; set; }
    }

    public class Items146
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items147 items { get; set; }
    }

    public class Items147
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsMilestonesDestinymilestonequestrewarditem
    {
        public string description { get; set; }
        public Properties246 properties { get; set; }
    }

    public class Properties246
    {
        public Vendorhash2 vendorHash { get; set; }
        public Vendoritemindex2 vendorItemIndex { get; set; }
        public Itemhash7 itemHash { get; set; }
        public Iteminstanceid3 itemInstanceId { get; set; }
        public Quantity3 quantity { get; set; }
    }

    public class Vendorhash2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition103 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition103
    {
        public string _ref { get; set; }
    }

    public class Vendoritemindex2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemhash7
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition104 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition104
    {
        public string _ref { get; set; }
    }

    public class Iteminstanceid3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Quantity3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsMilestonesDestinymilestoneactivitydefinition
    {
        public string description { get; set; }
        public Properties247 properties { get; set; }
    }

    public class Properties247
    {
        public Conceptualactivityhash conceptualActivityHash { get; set; }
        public Variants1 variants { get; set; }
    }

    public class Conceptualactivityhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition105 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition105
    {
        public string _ref { get; set; }
    }

    public class Variants1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties91 additionalProperties { get; set; }
        public XMappedDefinition106 xmappeddefinition { get; set; }
    }

    public class Additionalproperties91
    {
        public string _ref { get; set; }
    }

    public class XMappedDefinition106
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsMilestonesDestinymilestoneactivityvariantdefinition
    {
        public string description { get; set; }
        public Properties248 properties { get; set; }
    }

    public class Properties248
    {
        public Activityhash5 activityHash { get; set; }
        public Order order { get; set; }
    }

    public class Activityhash5
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition107 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition107
    {
        public string _ref { get; set; }
    }

    public class Order
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsMilestonesDestinymilestonerewardcategorydefinition
    {
        public string description { get; set; }
        public Properties249 properties { get; set; }
    }

    public class Properties249
    {
        public Categoryhash2 categoryHash { get; set; }
        public Categoryidentifier1 categoryIdentifier { get; set; }
        public Displayproperties33 displayProperties { get; set; }
        public Rewardentries rewardEntries { get; set; }
        public Order1 order { get; set; }
    }

    public class Categoryhash2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Categoryidentifier1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displayproperties33
    {
        public string description { get; set; }
        public Allof119[] allOf { get; set; }
    }

    public class Allof119
    {
        public string _ref { get; set; }
    }

    public class Rewardentries
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties92 additionalProperties { get; set; }
    }

    public class Additionalproperties92
    {
        public string _ref { get; set; }
    }

    public class Order1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsMilestonesDestinymilestonerewardentrydefinition
    {
        public string description { get; set; }
        public Properties250 properties { get; set; }
    }

    public class Properties250
    {
        public Rewardentryhash1 rewardEntryHash { get; set; }
        public Rewardentryidentifier rewardEntryIdentifier { get; set; }
        public Items148 items { get; set; }
        public Vendorhash3 vendorHash { get; set; }
        public Displayproperties34 displayProperties { get; set; }
        public Order2 order { get; set; }
    }

    public class Rewardentryhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Rewardentryidentifier
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Items148
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items149 items { get; set; }
    }

    public class Items149
    {
        public string _ref { get; set; }
    }

    public class Vendorhash3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition108 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition108
    {
        public string _ref { get; set; }
    }

    public class Displayproperties34
    {
        public string description { get; set; }
        public Allof120[] allOf { get; set; }
    }

    public class Allof120
    {
        public string _ref { get; set; }
    }

    public class Order2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyDefinitionsMilestonesDestinymilestonevendordefinition
    {
        public string description { get; set; }
        public Properties251 properties { get; set; }
    }

    public class Properties251
    {
        public Vendorhash4 vendorHash { get; set; }
    }

    public class Vendorhash4
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition109 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition109
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsMilestonesDestinymilestonevaluedefinition
    {
        public string description { get; set; }
        public Properties252 properties { get; set; }
    }

    public class Properties252
    {
        public Key key { get; set; }
        public Displayproperties35 displayProperties { get; set; }
    }

    public class Key
    {
        public string type { get; set; }
    }

    public class Displayproperties35
    {
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint64anddestinycharacterprogressioncomponent
    {
        public Properties253 properties { get; set; }
    }

    public class Properties253
    {
        public Data6 data { get; set; }
        public Privacy7 privacy { get; set; }
    }

    public class Data6
    {
        public string type { get; set; }
        public Additionalproperties93 additionalProperties { get; set; }
    }

    public class Additionalproperties93
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy7
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesCharactersDestinycharacterrendercomponent
    {
        public string description { get; set; }
        public Properties254 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties254
    {
        public Customdyes1 customDyes { get; set; }
        public Customization customization { get; set; }
        public Peerview peerView { get; set; }
    }

    public class Customdyes1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items150 items { get; set; }
    }

    public class Items150
    {
        public string _ref { get; set; }
    }

    public class Customization
    {
        public string description { get; set; }
        public Allof121[] allOf { get; set; }
    }

    public class Allof121
    {
        public string _ref { get; set; }
    }

    public class Peerview
    {
        public string description { get; set; }
        public Allof122[] allOf { get; set; }
    }

    public class Allof122
    {
        public string _ref { get; set; }
    }

    public class DestinyCharacterDestinycharactercustomization
    {
        public string description { get; set; }
        public Properties255 properties { get; set; }
    }

    public class Properties255
    {
        public Personality personality { get; set; }
        public Face face { get; set; }
        public Skincolor skinColor { get; set; }
        public Lipcolor lipColor { get; set; }
        public Eyecolor eyeColor { get; set; }
        public Haircolors hairColors { get; set; }
        public Featurecolors featureColors { get; set; }
        public Decalcolor decalColor { get; set; }
        public Wearhelmet wearHelmet { get; set; }
        public Hairindex hairIndex { get; set; }
        public Featureindex featureIndex { get; set; }
        public Decalindex decalIndex { get; set; }
    }

    public class Personality
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Face
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Skincolor
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Lipcolor
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Eyecolor
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Haircolors
    {
        public string type { get; set; }
        public Items151 items { get; set; }
    }

    public class Items151
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Featurecolors
    {
        public string type { get; set; }
        public Items152 items { get; set; }
    }

    public class Items152
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Decalcolor
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Wearhelmet
    {
        public string type { get; set; }
    }

    public class Hairindex
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Featureindex
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Decalindex
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyCharacterDestinycharacterpeerview
    {
        public string description { get; set; }
        public Properties256 properties { get; set; }
    }

    public class Properties256
    {
        public Equipment equipment { get; set; }
    }

    public class Equipment
    {
        public string type { get; set; }
        public Items153 items { get; set; }
    }

    public class Items153
    {
        public string _ref { get; set; }
    }

    public class DestinyCharacterDestinyitempeerview
    {
        public string description { get; set; }
        public Properties257 properties { get; set; }
    }

    public class Properties257
    {
        public Itemhash8 itemHash { get; set; }
        public Dyes dyes { get; set; }
    }

    public class Itemhash8
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition110 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition110
    {
        public string _ref { get; set; }
    }

    public class Dyes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items154 items { get; set; }
    }

    public class Items154
    {
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint64anddestinycharacterrendercomponent
    {
        public Properties258 properties { get; set; }
    }

    public class Properties258
    {
        public Data7 data { get; set; }
        public Privacy8 privacy { get; set; }
    }

    public class Data7
    {
        public string type { get; set; }
        public Additionalproperties94 additionalProperties { get; set; }
    }

    public class Additionalproperties94
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy8
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesCharactersDestinycharacteractivitiescomponent
    {
        public string description { get; set; }
        public Properties259 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties259
    {
        public Dateactivitystarted dateActivityStarted { get; set; }
        public Availableactivities availableActivities { get; set; }
        public Currentactivityhash currentActivityHash { get; set; }
        public Currentactivitymodehash currentActivityModeHash { get; set; }
        public Lastcompletedstoryhash lastCompletedStoryHash { get; set; }
    }

    public class Dateactivitystarted
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Availableactivities
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items155 items { get; set; }
    }

    public class Items155
    {
        public string _ref { get; set; }
    }

    public class Currentactivityhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition111 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition111
    {
        public string _ref { get; set; }
    }

    public class Currentactivitymodehash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition112 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition112
    {
        public string _ref { get; set; }
    }

    public class Lastcompletedstoryhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition113 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition113
    {
        public string _ref { get; set; }
    }

    public class DestinyDestinyactivity
    {
        public string description { get; set; }
        public Properties260 properties { get; set; }
    }

    public class Properties260
    {
        public Activityhash6 activityHash { get; set; }
        public Isnew isNew { get; set; }
        public Canlead canLead { get; set; }
        public Canjoin canJoin { get; set; }
        public Iscompleted isCompleted { get; set; }
        public Isvisible isVisible { get; set; }
        public Displaylevel displayLevel { get; set; }
        public Recommendedlight recommendedLight { get; set; }
        public Difficultytier difficultyTier { get; set; }
    }

    public class Activityhash6
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition114 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition114
    {
        public string _ref { get; set; }
    }

    public class Isnew
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canlead
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canjoin
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Iscompleted
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Isvisible
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displaylevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Recommendedlight
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Difficultytier
    {
        public string description { get; set; }
        public Allof123[] allOf { get; set; }
    }

    public class Allof123
    {
        public string _ref { get; set; }
    }

    public class DestinyDestinyactivitydifficultytier
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues62[] xenumvalues { get; set; }
    }

    public class XEnumValues62
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDefinitionsDestinyactivitymodedefinition
    {
        public Properties261 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties261
    {
        public Displayproperties36 displayProperties { get; set; }
        public Pgcrimage1 pgcrImage { get; set; }
        public Modetype modeType { get; set; }
        public Activitymodecategory activityModeCategory { get; set; }
        public Parenthashes parentHashes { get; set; }
        public Friendlyname1 friendlyName { get; set; }
        public Activitymodemappings activityModeMappings { get; set; }
        public Display display { get; set; }
        public Order3 order { get; set; }
        public Hash33 hash { get; set; }
        public Index33 index { get; set; }
        public Redacted32 redacted { get; set; }
    }

    public class Displayproperties36
    {
        public string _ref { get; set; }
    }

    public class Pgcrimage1
    {
        public string type { get; set; }
    }

    public class Modetype
    {
        public string _ref { get; set; }
    }

    public class Activitymodecategory
    {
        public string _ref { get; set; }
    }

    public class Parenthashes
    {
        public string type { get; set; }
        public Items156 items { get; set; }
    }

    public class Items156
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Friendlyname1
    {
        public string type { get; set; }
    }

    public class Activitymodemappings
    {
        public string type { get; set; }
        public Additionalproperties95 additionalProperties { get; set; }
    }

    public class Additionalproperties95
    {
        public string _ref { get; set; }
    }

    public class Display
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Order3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hash33
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index33
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted32
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyHistoricalstatsDefinitionsDestinyactivitymodetype
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues63[] xenumvalues { get; set; }
    }

    public class XEnumValues63
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDestinyactivitymodecategory
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues64[] xenumvalues { get; set; }
    }

    public class XEnumValues64
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
    }

    public class Dictionarycomponentresponseofint64anddestinycharacteractivitiescomponent
    {
        public Properties262 properties { get; set; }
    }

    public class Properties262
    {
        public Data8 data { get; set; }
        public Privacy9 privacy { get; set; }
    }

    public class Data8
    {
        public string type { get; set; }
        public Additionalproperties96 additionalProperties { get; set; }
    }

    public class Additionalproperties96
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy9
    {
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint64anddestinykioskscomponent
    {
        public Properties263 properties { get; set; }
    }

    public class Properties263
    {
        public Data9 data { get; set; }
        public Privacy10 privacy { get; set; }
    }

    public class Data9
    {
        public string type { get; set; }
        public Additionalproperties97 additionalProperties { get; set; }
    }

    public class Additionalproperties97
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy10
    {
        public string _ref { get; set; }
    }

    public class Destinyitemcomponentsetofint64
    {
        public Properties264 properties { get; set; }
    }

    public class Properties264
    {
        public Instances instances { get; set; }
        public Objectives1 objectives { get; set; }
        public Perks2 perks { get; set; }
        public Renderdata renderData { get; set; }
        public Stats4 stats { get; set; }
        public Sockets1 sockets { get; set; }
        public Talentgrids talentGrids { get; set; }
        public Plugstates plugStates { get; set; }
    }

    public class Instances
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Objectives1
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Perks2
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Renderdata
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Stats4
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Sockets1
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Talentgrids
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Plugstates
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class DestinyEntitiesItemsDestinyiteminstancecomponent
    {
        public string description { get; set; }
        public Properties265 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties265
    {
        public Damagetype2 damageType { get; set; }
        public Damagetypehash2 damageTypeHash { get; set; }
        public Primarystat primaryStat { get; set; }
        public Itemlevel itemLevel { get; set; }
        public Quality1 quality { get; set; }
        public Isequipped isEquipped { get; set; }
        public Canequip canEquip { get; set; }
        public Equiprequiredlevel equipRequiredLevel { get; set; }
        public Unlockhashesrequiredtoequip unlockHashesRequiredToEquip { get; set; }
        public Cannotequipreason cannotEquipReason { get; set; }
    }

    public class Damagetype2
    {
        public string description { get; set; }
        public Allof124[] allOf { get; set; }
    }

    public class Allof124
    {
        public string _ref { get; set; }
    }

    public class Damagetypehash2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition115 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition115
    {
        public string _ref { get; set; }
    }

    public class Primarystat
    {
        public string description { get; set; }
        public Allof125[] allOf { get; set; }
    }

    public class Allof125
    {
        public string _ref { get; set; }
    }

    public class Itemlevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Quality1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Isequipped
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canequip
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Equiprequiredlevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Unlockhashesrequiredtoequip
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items157 items { get; set; }
        public XMappedDefinition116 xmappeddefinition { get; set; }
    }

    public class Items157
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition116
    {
        public string _ref { get; set; }
    }

    public class Cannotequipreason
    {
        public string description { get; set; }
        public Allof126[] allOf { get; set; }
    }

    public class Allof126
    {
        public string _ref { get; set; }
    }

    public class DestinyDestinystat
    {
        public string description { get; set; }
        public Properties266 properties { get; set; }
    }

    public class Properties266
    {
        public Stathash3 statHash { get; set; }
        public Value5 value { get; set; }
        public Maximumvalue2 maximumValue { get; set; }
    }

    public class Stathash3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition117 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition117
    {
        public string _ref { get; set; }
    }

    public class Value5
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Maximumvalue2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyEquipfailurereason
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues65[] xenumvalues { get; set; }
    }

    public class XEnumValues65
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
    }

    public class DestinyDefinitionsDestinyunlockdefinition
    {
        public string description { get; set; }
        public Properties267 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties267
    {
        public Displayproperties37 displayProperties { get; set; }
        public Hash34 hash { get; set; }
        public Index34 index { get; set; }
        public Redacted33 redacted { get; set; }
    }

    public class Displayproperties37
    {
        public string description { get; set; }
        public Allof127[] allOf { get; set; }
    }

    public class Allof127
    {
        public string _ref { get; set; }
    }

    public class Hash34
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Index34
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Redacted33
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Dictionarycomponentresponseofint64anddestinyiteminstancecomponent
    {
        public Properties268 properties { get; set; }
    }

    public class Properties268
    {
        public Data10 data { get; set; }
        public Privacy11 privacy { get; set; }
    }

    public class Data10
    {
        public string type { get; set; }
        public Additionalproperties98 additionalProperties { get; set; }
    }

    public class Additionalproperties98
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy11
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesItemsDestinyitemobjectivescomponent
    {
        public string description { get; set; }
        public Properties269 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties269
    {
        public Objectives2 objectives { get; set; }
    }

    public class Objectives2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items158 items { get; set; }
    }

    public class Items158
    {
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint64anddestinyitemobjectivescomponent
    {
        public Properties270 properties { get; set; }
    }

    public class Properties270
    {
        public Data11 data { get; set; }
        public Privacy12 privacy { get; set; }
    }

    public class Data11
    {
        public string type { get; set; }
        public Additionalproperties99 additionalProperties { get; set; }
    }

    public class Additionalproperties99
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy12
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesItemsDestinyitemperkscomponent
    {
        public string description { get; set; }
        public Properties271 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties271
    {
        public Perks3 perks { get; set; }
    }

    public class Perks3
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items159 items { get; set; }
    }

    public class Items159
    {
        public string _ref { get; set; }
    }

    public class DestinyPerksDestinyperkreference
    {
        public string description { get; set; }
        public Properties272 properties { get; set; }
    }

    public class Properties272
    {
        public Perkhash2 perkHash { get; set; }
        public Iconpath2 iconPath { get; set; }
        public Isactive1 isActive { get; set; }
        public Visible3 visible { get; set; }
    }

    public class Perkhash2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition118 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition118
    {
        public string _ref { get; set; }
    }

    public class Iconpath2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Isactive1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Visible3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Dictionarycomponentresponseofint64anddestinyitemperkscomponent
    {
        public Properties273 properties { get; set; }
    }

    public class Properties273
    {
        public Data12 data { get; set; }
        public Privacy13 privacy { get; set; }
    }

    public class Data12
    {
        public string type { get; set; }
        public Additionalproperties100 additionalProperties { get; set; }
    }

    public class Additionalproperties100
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy13
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesItemsDestinyitemrendercomponent
    {
        public string description { get; set; }
        public Properties274 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties274
    {
        public Usecustomdyes useCustomDyes { get; set; }
        public Artregions artRegions { get; set; }
    }

    public class Usecustomdyes
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Artregions
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties101 additionalProperties { get; set; }
    }

    public class Additionalproperties101
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Dictionarycomponentresponseofint64anddestinyitemrendercomponent
    {
        public Properties275 properties { get; set; }
    }

    public class Properties275
    {
        public Data13 data { get; set; }
        public Privacy14 privacy { get; set; }
    }

    public class Data13
    {
        public string type { get; set; }
        public Additionalproperties102 additionalProperties { get; set; }
    }

    public class Additionalproperties102
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy14
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesItemsDestinyitemstatscomponent
    {
        public string description { get; set; }
        public Properties276 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties276
    {
        public Stats5 stats { get; set; }
    }

    public class Stats5
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties103 additionalProperties { get; set; }
        public XMappedDefinition119 xmappeddefinition { get; set; }
    }

    public class Additionalproperties103
    {
        public string _ref { get; set; }
    }

    public class XMappedDefinition119
    {
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint64anddestinyitemstatscomponent
    {
        public Properties277 properties { get; set; }
    }

    public class Properties277
    {
        public Data14 data { get; set; }
        public Privacy15 privacy { get; set; }
    }

    public class Data14
    {
        public string type { get; set; }
        public Additionalproperties104 additionalProperties { get; set; }
    }

    public class Additionalproperties104
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy15
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesItemsDestinyitemsocketscomponent
    {
        public string description { get; set; }
        public Properties278 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties278
    {
        public Sockets2 sockets { get; set; }
    }

    public class Sockets2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items160 items { get; set; }
    }

    public class Items160
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesItemsDestinyitemsocketstate
    {
        public string description { get; set; }
        public Properties279 properties { get; set; }
    }

    public class Properties279
    {
        public Plughash plugHash { get; set; }
        public Isenabled isEnabled { get; set; }
        public Enablefailindexes enableFailIndexes { get; set; }
        public Reusableplughashes reusablePlugHashes { get; set; }
    }

    public class Plughash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition120 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition120
    {
        public string _ref { get; set; }
    }

    public class Isenabled
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Enablefailindexes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items161 items { get; set; }
    }

    public class Items161
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Reusableplughashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items162 items { get; set; }
        public XMappedDefinition121 xmappeddefinition { get; set; }
    }

    public class Items162
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition121
    {
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint64anddestinyitemsocketscomponent
    {
        public Properties280 properties { get; set; }
    }

    public class Properties280
    {
        public Data15 data { get; set; }
        public Privacy16 privacy { get; set; }
    }

    public class Data15
    {
        public string type { get; set; }
        public Additionalproperties105 additionalProperties { get; set; }
    }

    public class Additionalproperties105
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy16
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesItemsDestinyitemtalentgridcomponent
    {
        public string description { get; set; }
        public Properties281 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties281
    {
        public Talentgridhash1 talentGridHash { get; set; }
        public Nodes2 nodes { get; set; }
        public Isgridcomplete isGridComplete { get; set; }
        public Gridprogression gridProgression { get; set; }
    }

    public class Talentgridhash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition122 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition122
    {
        public string _ref { get; set; }
    }

    public class Nodes2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items163 items { get; set; }
    }

    public class Items163
    {
        public string _ref { get; set; }
    }

    public class Isgridcomplete
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Gridprogression
    {
        public string description { get; set; }
        public Allof128[] allOf { get; set; }
    }

    public class Allof128
    {
        public string _ref { get; set; }
    }

    public class DestinyDestinytalentnode
    {
        public string description { get; set; }
        public Properties282 properties { get; set; }
    }

    public class Properties282
    {
        public Nodeindex1 nodeIndex { get; set; }
        public Nodehash1 nodeHash { get; set; }
        public State1 state { get; set; }
        public Isactivated isActivated { get; set; }
        public Stepindex3 stepIndex { get; set; }
        public Materialstoupgrade materialsToUpgrade { get; set; }
        public Activationgridlevel activationGridLevel { get; set; }
        public Progresspercent progressPercent { get; set; }
        public Hidden hidden { get; set; }
        public Nodestatsblock nodeStatsBlock { get; set; }
    }

    public class Nodeindex1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Nodehash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class State1
    {
        public string description { get; set; }
        public Allof129[] allOf { get; set; }
    }

    public class Allof129
    {
        public string _ref { get; set; }
    }

    public class Isactivated
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Stepindex3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Materialstoupgrade
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items164 items { get; set; }
    }

    public class Items164
    {
        public string _ref { get; set; }
    }

    public class Activationgridlevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Progresspercent
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Hidden
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Nodestatsblock
    {
        public string description { get; set; }
        public Allof130[] allOf { get; set; }
    }

    public class Allof130
    {
        public string _ref { get; set; }
    }

    public class DestinyDestinytalentnodestate
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues66[] xenumvalues { get; set; }
    }

    public class XEnumValues66
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDestinytalentnodestatblock
    {
        public string description { get; set; }
        public Properties283 properties { get; set; }
    }

    public class Properties283
    {
        public Currentstepstats currentStepStats { get; set; }
        public Nextstepstats nextStepStats { get; set; }
    }

    public class Currentstepstats
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items165 items { get; set; }
    }

    public class Items165
    {
        public string _ref { get; set; }
    }

    public class Nextstepstats
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items166 items { get; set; }
    }

    public class Items166
    {
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint64anddestinyitemtalentgridcomponent
    {
        public Properties284 properties { get; set; }
    }

    public class Properties284
    {
        public Data16 data { get; set; }
        public Privacy17 privacy { get; set; }
    }

    public class Data16
    {
        public string type { get; set; }
        public Additionalproperties106 additionalProperties { get; set; }
    }

    public class Additionalproperties106
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy17
    {
        public string _ref { get; set; }
    }

    public class DestinyComponentsItemsDestinyitemplugcomponent
    {
        public string description { get; set; }
        public Properties285 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties285
    {
        public Insertfailindexes insertFailIndexes { get; set; }
        public Enablefailindexes1 enableFailIndexes { get; set; }
    }

    public class Insertfailindexes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items167 items { get; set; }
    }

    public class Items167
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Enablefailindexes1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items168 items { get; set; }
    }

    public class Items168
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Dictionarycomponentresponseofuint32anddestinyitemplugcomponent
    {
        public Properties286 properties { get; set; }
    }

    public class Properties286
    {
        public Data17 data { get; set; }
        public Privacy18 privacy { get; set; }
    }

    public class Data17
    {
        public string type { get; set; }
        public Additionalproperties107 additionalProperties { get; set; }
    }

    public class Additionalproperties107
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy18
    {
        public string _ref { get; set; }
    }

    public class DestinyResponsesDestinycharacterresponse
    {
        public string description { get; set; }
        public Properties287 properties { get; set; }
    }

    public class Properties287
    {
        public Inventory1 inventory { get; set; }
        public Character character { get; set; }
        public Progressions1 progressions { get; set; }
        public Renderdata1 renderData { get; set; }
        public Activities2 activities { get; set; }
        public Equipment1 equipment { get; set; }
        public Kiosks kiosks { get; set; }
        public Itemcomponents1 itemComponents { get; set; }
    }

    public class Inventory1
    {
        public string description { get; set; }
        public Allof131[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof131
    {
        public string _ref { get; set; }
    }

    public class Character
    {
        public string description { get; set; }
        public Allof132[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof132
    {
        public string _ref { get; set; }
    }

    public class Progressions1
    {
        public string description { get; set; }
        public Allof133[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof133
    {
        public string _ref { get; set; }
    }

    public class Renderdata1
    {
        public string description { get; set; }
        public Allof134[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof134
    {
        public string _ref { get; set; }
    }

    public class Activities2
    {
        public string description { get; set; }
        public Allof135[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof135
    {
        public string _ref { get; set; }
    }

    public class Equipment1
    {
        public string description { get; set; }
        public Allof136[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof136
    {
        public string _ref { get; set; }
    }

    public class Kiosks
    {
        public string description { get; set; }
        public Allof137[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof137
    {
        public string _ref { get; set; }
    }

    public class Itemcomponents1
    {
        public string description { get; set; }
        public Allof138[] allOf { get; set; }
    }

    public class Allof138
    {
        public string _ref { get; set; }
    }

    public class Singlecomponentresponseofdestinycharactercomponent
    {
        public Properties288 properties { get; set; }
    }

    public class Properties288
    {
        public Data18 data { get; set; }
        public Privacy19 privacy { get; set; }
    }

    public class Data18
    {
        public string _ref { get; set; }
    }

    public class Privacy19
    {
        public string _ref { get; set; }
    }

    public class Singlecomponentresponseofdestinycharacterprogressioncomponent
    {
        public Properties289 properties { get; set; }
    }

    public class Properties289
    {
        public Data19 data { get; set; }
        public Privacy20 privacy { get; set; }
    }

    public class Data19
    {
        public string _ref { get; set; }
    }

    public class Privacy20
    {
        public string _ref { get; set; }
    }

    public class Singlecomponentresponseofdestinycharacterrendercomponent
    {
        public Properties290 properties { get; set; }
    }

    public class Properties290
    {
        public Data20 data { get; set; }
        public Privacy21 privacy { get; set; }
    }

    public class Data20
    {
        public string _ref { get; set; }
    }

    public class Privacy21
    {
        public string _ref { get; set; }
    }

    public class Singlecomponentresponseofdestinycharacteractivitiescomponent
    {
        public Properties291 properties { get; set; }
    }

    public class Properties291
    {
        public Data21 data { get; set; }
        public Privacy22 privacy { get; set; }
    }

    public class Data21
    {
        public string _ref { get; set; }
    }

    public class Privacy22
    {
        public string _ref { get; set; }
    }

    public class DestinyResponsesDestinyitemresponse
    {
        public string description { get; set; }
        public Properties292 properties { get; set; }
    }

    public class Properties292
    {
        public Characterid1 characterId { get; set; }
        public Item item { get; set; }
        public Instance instance { get; set; }
        public Objectives3 objectives { get; set; }
        public Perks4 perks { get; set; }
        public Renderdata2 renderData { get; set; }
        public Stats6 stats { get; set; }
        public Talentgrid1 talentGrid { get; set; }
        public Sockets3 sockets { get; set; }
    }

    public class Characterid1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Item
    {
        public string description { get; set; }
        public Allof139[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof139
    {
        public string _ref { get; set; }
    }

    public class Instance
    {
        public string description { get; set; }
        public Allof140[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof140
    {
        public string _ref { get; set; }
    }

    public class Objectives3
    {
        public string description { get; set; }
        public Allof141[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof141
    {
        public string _ref { get; set; }
    }

    public class Perks4
    {
        public string description { get; set; }
        public Allof142[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof142
    {
        public string _ref { get; set; }
    }

    public class Renderdata2
    {
        public string description { get; set; }
        public Allof143[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof143
    {
        public string _ref { get; set; }
    }

    public class Stats6
    {
        public string description { get; set; }
        public Allof144[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof144
    {
        public string _ref { get; set; }
    }

    public class Talentgrid1
    {
        public string description { get; set; }
        public Allof145[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof145
    {
        public string _ref { get; set; }
    }

    public class Sockets3
    {
        public string description { get; set; }
        public Allof146[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof146
    {
        public string _ref { get; set; }
    }

    public class Singlecomponentresponseofdestinyitemcomponent
    {
        public Properties293 properties { get; set; }
    }

    public class Properties293
    {
        public Data22 data { get; set; }
        public Privacy23 privacy { get; set; }
    }

    public class Data22
    {
        public string _ref { get; set; }
    }

    public class Privacy23
    {
        public string _ref { get; set; }
    }

    public class Singlecomponentresponseofdestinyiteminstancecomponent
    {
        public Properties294 properties { get; set; }
    }

    public class Properties294
    {
        public Data23 data { get; set; }
        public Privacy24 privacy { get; set; }
    }

    public class Data23
    {
        public string _ref { get; set; }
    }

    public class Privacy24
    {
        public string _ref { get; set; }
    }

    public class Singlecomponentresponseofdestinyitemobjectivescomponent
    {
        public Properties295 properties { get; set; }
    }

    public class Properties295
    {
        public Data24 data { get; set; }
        public Privacy25 privacy { get; set; }
    }

    public class Data24
    {
        public string _ref { get; set; }
    }

    public class Privacy25
    {
        public string _ref { get; set; }
    }

    public class Singlecomponentresponseofdestinyitemperkscomponent
    {
        public Properties296 properties { get; set; }
    }

    public class Properties296
    {
        public Data25 data { get; set; }
        public Privacy26 privacy { get; set; }
    }

    public class Data25
    {
        public string _ref { get; set; }
    }

    public class Privacy26
    {
        public string _ref { get; set; }
    }

    public class Singlecomponentresponseofdestinyitemrendercomponent
    {
        public Properties297 properties { get; set; }
    }

    public class Properties297
    {
        public Data26 data { get; set; }
        public Privacy27 privacy { get; set; }
    }

    public class Data26
    {
        public string _ref { get; set; }
    }

    public class Privacy27
    {
        public string _ref { get; set; }
    }

    public class Singlecomponentresponseofdestinyitemstatscomponent
    {
        public Properties298 properties { get; set; }
    }

    public class Properties298
    {
        public Data27 data { get; set; }
        public Privacy28 privacy { get; set; }
    }

    public class Data27
    {
        public string _ref { get; set; }
    }

    public class Privacy28
    {
        public string _ref { get; set; }
    }

    public class Singlecomponentresponseofdestinyitemtalentgridcomponent
    {
        public Properties299 properties { get; set; }
    }

    public class Properties299
    {
        public Data28 data { get; set; }
        public Privacy29 privacy { get; set; }
    }

    public class Data28
    {
        public string _ref { get; set; }
    }

    public class Privacy29
    {
        public string _ref { get; set; }
    }

    public class Singlecomponentresponseofdestinyitemsocketscomponent
    {
        public Properties300 properties { get; set; }
    }

    public class Properties300
    {
        public Data29 data { get; set; }
        public Privacy30 privacy { get; set; }
    }

    public class Data29
    {
        public string _ref { get; set; }
    }

    public class Privacy30
    {
        public string _ref { get; set; }
    }

    public class DestinyResponsesDestinyvendorresponse
    {
        public string description { get; set; }
        public Properties301 properties { get; set; }
    }

    public class Properties301
    {
        public Vendor vendor { get; set; }
        public Categories1 categories { get; set; }
        public Sales sales { get; set; }
        public Items169 items { get; set; }
    }

    public class Vendor
    {
        public string description { get; set; }
        public Allof147[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof147
    {
        public string _ref { get; set; }
    }

    public class Categories1
    {
        public string description { get; set; }
        public Allof148[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof148
    {
        public string _ref { get; set; }
    }

    public class Sales
    {
        public string description { get; set; }
        public Allof149[] allOf { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Allof149
    {
        public string _ref { get; set; }
    }

    public class Items169
    {
        public string description { get; set; }
        public Allof150[] allOf { get; set; }
    }

    public class Allof150
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesVendorsDestinyvendorcomponent
    {
        public string description { get; set; }
        public Properties302 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties302
    {
        public Vendorhash5 vendorHash { get; set; }
        public Ackstate ackState { get; set; }
        public Nextrefreshdate nextRefreshDate { get; set; }
        public Enabled2 enabled { get; set; }
        public Canpurchase canPurchase { get; set; }
        public Progression progression { get; set; }
    }

    public class Vendorhash5
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition123 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition123
    {
        public string _ref { get; set; }
    }

    public class Ackstate
    {
        public string description { get; set; }
        public Allof151[] allOf { get; set; }
    }

    public class Allof151
    {
        public string _ref { get; set; }
    }

    public class Nextrefreshdate
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Enabled2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Canpurchase
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Progression
    {
        public string description { get; set; }
        public Allof152[] allOf { get; set; }
    }

    public class Allof152
    {
        public string _ref { get; set; }
    }

    public class UserAckstate
    {
        public Properties303 properties { get; set; }
    }

    public class Properties303
    {
        public Needsack needsAck { get; set; }
        public Ackid ackId { get; set; }
    }

    public class Needsack
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Ackid
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Singlecomponentresponseofdestinyvendorcomponent
    {
        public Properties304 properties { get; set; }
    }

    public class Properties304
    {
        public Data30 data { get; set; }
        public Privacy31 privacy { get; set; }
    }

    public class Data30
    {
        public string _ref { get; set; }
    }

    public class Privacy31
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesVendorsDestinyvendorcategoriescomponent
    {
        public string description { get; set; }
        public Properties305 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties305
    {
        public Categories2 categories { get; set; }
    }

    public class Categories2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items170 items { get; set; }
    }

    public class Items170
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesVendorsDestinyvendorcategory
    {
        public string description { get; set; }
        public Properties306 properties { get; set; }
    }

    public class Properties306
    {
        public Categoryindex2 categoryIndex { get; set; }
        public Itemindexes itemIndexes { get; set; }
    }

    public class Categoryindex2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemindexes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items171 items { get; set; }
    }

    public class Items171
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Singlecomponentresponseofdestinyvendorcategoriescomponent
    {
        public Properties307 properties { get; set; }
    }

    public class Properties307
    {
        public Data31 data { get; set; }
        public Privacy32 privacy { get; set; }
    }

    public class Data31
    {
        public string _ref { get; set; }
    }

    public class Privacy32
    {
        public string _ref { get; set; }
    }

    public class DestinyEntitiesVendorsDestinyvendorsaleitemcomponent
    {
        public string description { get; set; }
        public Properties308 properties { get; set; }
        public string xdestinycomponenttypedependency { get; set; }
    }

    public class Properties308
    {
        public Vendoritemindex3 vendorItemIndex { get; set; }
        public Itemhash9 itemHash { get; set; }
        public Salestatus saleStatus { get; set; }
        public Costs costs { get; set; }
        public Requiredunlocks requiredUnlocks { get; set; }
        public Unlockstatuses unlockStatuses { get; set; }
        public Failureindexes2 failureIndexes { get; set; }
    }

    public class Vendoritemindex3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Itemhash9
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition124 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition124
    {
        public string _ref { get; set; }
    }

    public class Salestatus
    {
        public string description { get; set; }
        public Allof153[] allOf { get; set; }
    }

    public class Allof153
    {
        public string _ref { get; set; }
    }

    public class Costs
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items172 items { get; set; }
    }

    public class Items172
    {
        public string _ref { get; set; }
    }

    public class Requiredunlocks
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items173 items { get; set; }
        public XMappedDefinition125 xmappeddefinition { get; set; }
    }

    public class Items173
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition125
    {
        public string _ref { get; set; }
    }

    public class Unlockstatuses
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items174 items { get; set; }
    }

    public class Items174
    {
        public string _ref { get; set; }
    }

    public class Failureindexes2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items175 items { get; set; }
    }

    public class Items175
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class DestinyVendoritemstatus
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues67[] xenumvalues { get; set; }
    }

    public class XEnumValues67
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyDestinyunlockstatus
    {
        public string description { get; set; }
        public Properties309 properties { get; set; }
    }

    public class Properties309
    {
        public Unlockhash unlockHash { get; set; }
        public Isset isSet { get; set; }
    }

    public class Unlockhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition126 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition126
    {
        public string _ref { get; set; }
    }

    public class Isset
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Dictionarycomponentresponseofint32anddestinyvendorsaleitemcomponent
    {
        public Properties310 properties { get; set; }
    }

    public class Properties310
    {
        public Data32 data { get; set; }
        public Privacy33 privacy { get; set; }
    }

    public class Data32
    {
        public string type { get; set; }
        public Additionalproperties108 additionalProperties { get; set; }
    }

    public class Additionalproperties108
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy33
    {
        public string _ref { get; set; }
    }

    public class Destinyitemcomponentsetofint32
    {
        public Properties311 properties { get; set; }
    }

    public class Properties311
    {
        public Instances1 instances { get; set; }
        public Objectives4 objectives { get; set; }
        public Perks5 perks { get; set; }
        public Renderdata3 renderData { get; set; }
        public Stats7 stats { get; set; }
        public Sockets4 sockets { get; set; }
        public Talentgrids1 talentGrids { get; set; }
        public Plugstates1 plugStates { get; set; }
    }

    public class Instances1
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Objectives4
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Perks5
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Renderdata3
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Stats7
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Sockets4
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Talentgrids1
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Plugstates1
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint32anddestinyiteminstancecomponent
    {
        public Properties312 properties { get; set; }
    }

    public class Properties312
    {
        public Data33 data { get; set; }
        public Privacy34 privacy { get; set; }
    }

    public class Data33
    {
        public string type { get; set; }
        public Additionalproperties109 additionalProperties { get; set; }
    }

    public class Additionalproperties109
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy34
    {
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint32anddestinyitemobjectivescomponent
    {
        public Properties313 properties { get; set; }
    }

    public class Properties313
    {
        public Data34 data { get; set; }
        public Privacy35 privacy { get; set; }
    }

    public class Data34
    {
        public string type { get; set; }
        public Additionalproperties110 additionalProperties { get; set; }
    }

    public class Additionalproperties110
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy35
    {
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint32anddestinyitemperkscomponent
    {
        public Properties314 properties { get; set; }
    }

    public class Properties314
    {
        public Data35 data { get; set; }
        public Privacy36 privacy { get; set; }
    }

    public class Data35
    {
        public string type { get; set; }
        public Additionalproperties111 additionalProperties { get; set; }
    }

    public class Additionalproperties111
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy36
    {
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint32anddestinyitemrendercomponent
    {
        public Properties315 properties { get; set; }
    }

    public class Properties315
    {
        public Data36 data { get; set; }
        public Privacy37 privacy { get; set; }
    }

    public class Data36
    {
        public string type { get; set; }
        public Additionalproperties112 additionalProperties { get; set; }
    }

    public class Additionalproperties112
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy37
    {
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint32anddestinyitemstatscomponent
    {
        public Properties316 properties { get; set; }
    }

    public class Properties316
    {
        public Data37 data { get; set; }
        public Privacy38 privacy { get; set; }
    }

    public class Data37
    {
        public string type { get; set; }
        public Additionalproperties113 additionalProperties { get; set; }
    }

    public class Additionalproperties113
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy38
    {
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint32anddestinyitemsocketscomponent
    {
        public Properties317 properties { get; set; }
    }

    public class Properties317
    {
        public Data38 data { get; set; }
        public Privacy39 privacy { get; set; }
    }

    public class Data38
    {
        public string type { get; set; }
        public Additionalproperties114 additionalProperties { get; set; }
    }

    public class Additionalproperties114
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy39
    {
        public string _ref { get; set; }
    }

    public class Dictionarycomponentresponseofint32anddestinyitemtalentgridcomponent
    {
        public Properties318 properties { get; set; }
    }

    public class Properties318
    {
        public Data39 data { get; set; }
        public Privacy40 privacy { get; set; }
    }

    public class Data39
    {
        public string type { get; set; }
        public Additionalproperties115 additionalProperties { get; set; }
    }

    public class Additionalproperties115
    {
        public string xdestinycomponenttypedependency { get; set; }
        public string _ref { get; set; }
    }

    public class Privacy40
    {
        public string _ref { get; set; }
    }

    public class DestinyRequestsActionsDestinyactionrequest
    {
        public Properties319 properties { get; set; }
    }

    public class Properties319
    {
        public Membershiptype3 membershipType { get; set; }
    }

    public class Membershiptype3
    {
        public string _ref { get; set; }
    }

    public class DestinyRequestsActionsDestinycharacteractionrequest
    {
        public Properties320 properties { get; set; }
    }

    public class Properties320
    {
        public Characterid2 characterId { get; set; }
        public Membershiptype4 membershipType { get; set; }
    }

    public class Characterid2
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Membershiptype4
    {
        public string _ref { get; set; }
    }

    public class DestinyRequestsActionsDestinyitemactionrequest
    {
        public Properties321 properties { get; set; }
    }

    public class Properties321
    {
        public Itemid itemId { get; set; }
        public Characterid3 characterId { get; set; }
        public Membershiptype5 membershipType { get; set; }
    }

    public class Itemid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Characterid3
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Membershiptype5
    {
        public string _ref { get; set; }
    }

    public class DestinyRequestsDestinyitemtransferrequest
    {
        public Properties322 properties { get; set; }
    }

    public class Properties322
    {
        public Itemreferencehash itemReferenceHash { get; set; }
        public Stacksize stackSize { get; set; }
        public Transfertovault transferToVault { get; set; }
        public Itemid1 itemId { get; set; }
        public Characterid4 characterId { get; set; }
        public Membershiptype6 membershipType { get; set; }
    }

    public class Itemreferencehash
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Stacksize
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Transfertovault
    {
        public string type { get; set; }
    }

    public class Itemid1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Characterid4
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Membershiptype6
    {
        public string _ref { get; set; }
    }

    public class DestinyDestinyequipitemresults
    {
        public string description { get; set; }
        public Properties323 properties { get; set; }
    }

    public class Properties323
    {
        public Equipresults equipResults { get; set; }
    }

    public class Equipresults
    {
        public string type { get; set; }
        public Items176 items { get; set; }
    }

    public class Items176
    {
        public string _ref { get; set; }
    }

    public class DestinyDestinyequipitemresult
    {
        public string description { get; set; }
        public Properties324 properties { get; set; }
    }

    public class Properties324
    {
        public Iteminstanceid4 itemInstanceId { get; set; }
        public Equipstatus equipStatus { get; set; }
    }

    public class Iteminstanceid4
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Equipstatus
    {
        public string description { get; set; }
        public Allof154[] allOf { get; set; }
    }

    public class Allof154
    {
        public string _ref { get; set; }
    }

    public class ExceptionsPlatformerrorcodes
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues68[] xenumvalues { get; set; }
    }

    public class XEnumValues68
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
    }

    public class DestinyRequestsActionsDestinyitemsetactionrequest
    {
        public Properties325 properties { get; set; }
    }

    public class Properties325
    {
        public Itemids itemIds { get; set; }
        public Characterid5 characterId { get; set; }
        public Membershiptype7 membershipType { get; set; }
    }

    public class Itemids
    {
        public string type { get; set; }
        public Items177 items { get; set; }
    }

    public class Items177
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Characterid5
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Membershiptype7
    {
        public string _ref { get; set; }
    }

    public class DestinyRequestsActionsDestinyitemstaterequest
    {
        public Properties326 properties { get; set; }
    }

    public class Properties326
    {
        public State2 state { get; set; }
        public Itemid2 itemId { get; set; }
        public Characterid6 characterId { get; set; }
        public Membershiptype8 membershipType { get; set; }
    }

    public class State2
    {
        public string type { get; set; }
    }

    public class Itemid2
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Characterid6
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Membershiptype8
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinypostgamecarnagereportdata
    {
        public Properties327 properties { get; set; }
    }

    public class Properties327
    {
        public Period period { get; set; }
        public Activitydetails activityDetails { get; set; }
        public Entries1 entries { get; set; }
        public Teams teams { get; set; }
    }

    public class Period
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Activitydetails
    {
        public string description { get; set; }
        public Allof155[] allOf { get; set; }
    }

    public class Allof155
    {
        public string _ref { get; set; }
    }

    public class Entries1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items178 items { get; set; }
    }

    public class Items178
    {
        public string _ref { get; set; }
    }

    public class Teams
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items179 items { get; set; }
    }

    public class Items179
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyhistoricalstatsactivity
    {
        public Properties328 properties { get; set; }
    }

    public class Properties328
    {
        public Referenceid referenceId { get; set; }
        public Instanceid instanceId { get; set; }
        public Mode mode { get; set; }
        public Activitytypehashoverride activityTypeHashOverride { get; set; }
        public Isprivate isPrivate { get; set; }
    }

    public class Referenceid
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition127 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition127
    {
        public string _ref { get; set; }
    }

    public class Instanceid
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Mode
    {
        public string description { get; set; }
        public Allof156[] allOf { get; set; }
    }

    public class Allof156
    {
        public string _ref { get; set; }
    }

    public class Activitytypehashoverride
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition128 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition128
    {
        public string _ref { get; set; }
    }

    public class Isprivate
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyHistoricalstatsDestinypostgamecarnagereportentry
    {
        public Properties329 properties { get; set; }
    }

    public class Properties329
    {
        public Standing standing { get; set; }
        public Score score { get; set; }
        public Player player { get; set; }
        public Characterid7 characterId { get; set; }
        public Values2 values { get; set; }
        public Extended extended { get; set; }
    }

    public class Standing
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Score
    {
        public string description { get; set; }
        public Allof157[] allOf { get; set; }
    }

    public class Allof157
    {
        public string _ref { get; set; }
    }

    public class Player
    {
        public string description { get; set; }
        public Allof158[] allOf { get; set; }
    }

    public class Allof158
    {
        public string _ref { get; set; }
    }

    public class Characterid7
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Values2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties116 additionalProperties { get; set; }
    }

    public class Additionalproperties116
    {
        public string _ref { get; set; }
    }

    public class Extended
    {
        public string description { get; set; }
        public Allof159[] allOf { get; set; }
    }

    public class Allof159
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyhistoricalstatsvalue
    {
        public Properties330 properties { get; set; }
    }

    public class Properties330
    {
        public Statid statId { get; set; }
        public Basic basic { get; set; }
        public Pga pga { get; set; }
        public Weighted weighted { get; set; }
    }

    public class Statid
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Basic
    {
        public string description { get; set; }
        public Allof160[] allOf { get; set; }
    }

    public class Allof160
    {
        public string _ref { get; set; }
    }

    public class Pga
    {
        public string description { get; set; }
        public Allof161[] allOf { get; set; }
    }

    public class Allof161
    {
        public string _ref { get; set; }
    }

    public class Weighted
    {
        public string description { get; set; }
        public Allof162[] allOf { get; set; }
    }

    public class Allof162
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyhistoricalstatsvaluepair
    {
        public Properties331 properties { get; set; }
    }

    public class Properties331
    {
        public Value6 value { get; set; }
        public Displayvalue displayValue { get; set; }
    }

    public class Value6
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displayvalue
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyHistoricalstatsDestinyplayer
    {
        public Properties332 properties { get; set; }
    }

    public class Properties332
    {
        public Destinyuserinfo3 destinyUserInfo { get; set; }
        public Characterclass characterClass { get; set; }
        public Characterlevel characterLevel { get; set; }
        public Lightlevel lightLevel { get; set; }
        public Bungienetuserinfo3 bungieNetUserInfo { get; set; }
        public Clanname clanName { get; set; }
        public Clantag clanTag { get; set; }
    }

    public class Destinyuserinfo3
    {
        public string description { get; set; }
        public Allof163[] allOf { get; set; }
    }

    public class Allof163
    {
        public string _ref { get; set; }
    }

    public class Characterclass
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Characterlevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Lightlevel
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Bungienetuserinfo3
    {
        public string description { get; set; }
        public Allof164[] allOf { get; set; }
    }

    public class Allof164
    {
        public string _ref { get; set; }
    }

    public class Clanname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Clantag
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyHistoricalstatsDestinypostgamecarnagereportextendeddata
    {
        public Properties333 properties { get; set; }
    }

    public class Properties333
    {
        public Weapons weapons { get; set; }
        public Values3 values { get; set; }
    }

    public class Weapons
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items180 items { get; set; }
    }

    public class Items180
    {
        public string _ref { get; set; }
    }

    public class Values3
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties117 additionalProperties { get; set; }
    }

    public class Additionalproperties117
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyhistoricalweaponstats
    {
        public Properties334 properties { get; set; }
    }

    public class Properties334
    {
        public Referenceid1 referenceId { get; set; }
        public Values4 values { get; set; }
    }

    public class Referenceid1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition129 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition129
    {
        public string _ref { get; set; }
    }

    public class Values4
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties118 additionalProperties { get; set; }
    }

    public class Additionalproperties118
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinypostgamecarnagereportteamentry
    {
        public Properties335 properties { get; set; }
    }

    public class Properties335
    {
        public Teamid teamId { get; set; }
        public Standing1 standing { get; set; }
        public Score1 score { get; set; }
        public Teamname teamName { get; set; }
    }

    public class Teamid
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Standing1
    {
        public string description { get; set; }
        public Allof165[] allOf { get; set; }
    }

    public class Allof165
    {
        public string _ref { get; set; }
    }

    public class Score1
    {
        public string description { get; set; }
        public Allof166[] allOf { get; set; }
    }

    public class Allof166
    {
        public string _ref { get; set; }
    }

    public class Teamname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyHistoricalstatsDefinitionsDestinyhistoricalstatsdefinition
    {
        public Properties336 properties { get; set; }
        public string xmobilemanifestname { get; set; }
    }

    public class Properties336
    {
        public Statid1 statId { get; set; }
        public Group group { get; set; }
        public Periodtypes periodTypes { get; set; }
        public Modes modes { get; set; }
        public Category2 category { get; set; }
        public Statname statName { get; set; }
        public Statdescription statDescription { get; set; }
        public Unittype unitType { get; set; }
        public Iconimage iconImage { get; set; }
        public Mergemethod mergeMethod { get; set; }
        public Unitlabel unitLabel { get; set; }
        public Weight2 weight { get; set; }
        public Medaltierhash medalTierHash { get; set; }
    }

    public class Statid1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Group
    {
        public string description { get; set; }
        public Allof167[] allOf { get; set; }
    }

    public class Allof167
    {
        public string _ref { get; set; }
    }

    public class Periodtypes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items181 items { get; set; }
    }

    public class Items181
    {
        public string _ref { get; set; }
    }

    public class Modes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items182 items { get; set; }
    }

    public class Items182
    {
        public string _ref { get; set; }
    }

    public class Category2
    {
        public string description { get; set; }
        public Allof168[] allOf { get; set; }
    }

    public class Allof168
    {
        public string _ref { get; set; }
    }

    public class Statname
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Statdescription
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Unittype
    {
        public string description { get; set; }
        public Allof169[] allOf { get; set; }
    }

    public class Allof169
    {
        public string _ref { get; set; }
    }

    public class Iconimage
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Mergemethod
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues69[] xenumvalues { get; set; }
    }

    public class XEnumValues69
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
    }

    public class Unitlabel
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Weight2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Medaltierhash
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyHistoricalstatsDefinitionsDestinystatsgrouptype
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues70[] xenumvalues { get; set; }
    }

    public class XEnumValues70
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyHistoricalstatsDefinitionsPeriodtype
    {
        public string type { get; set; }
        public Items183 items { get; set; }
    }

    public class Items183
    {
        public string _ref { get; set; }
    }
    

    public class Items184
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDefinitionsDestinystatscategorytype
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues71[] xenumvalues { get; set; }
    }

    public class XEnumValues71
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyHistoricalstatsDefinitionsUnittype
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues72[] xenumvalues { get; set; }
    }

    public class XEnumValues72
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
    }

    public class DestinyHistoricalstatsDefinitionsDestinystatsmergemethod
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues73[] xenumvalues { get; set; }
    }

    public class XEnumValues73
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
        public string description { get; set; }
    }

    public class DestinyHistoricalstatsDestinyleaderboard
    {
        public Properties337 properties { get; set; }
    }

    public class Properties337
    {
        public Statid2 statId { get; set; }
        public Entries2 entries { get; set; }
    }

    public class Statid2
    {
        public string type { get; set; }
    }

    public class Entries2
    {
        public string type { get; set; }
        public Items185 items { get; set; }
    }

    public class Items185
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyleaderboardentry
    {
        public Properties338 properties { get; set; }
    }

    public class Properties338
    {
        public Rank rank { get; set; }
        public Player1 player { get; set; }
        public Characterid8 characterId { get; set; }
        public Value7 value { get; set; }
    }

    public class Rank
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Player1
    {
        public string description { get; set; }
        public Allof170[] allOf { get; set; }
    }

    public class Allof170
    {
        public string _ref { get; set; }
    }

    public class Characterid8
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Value7
    {
        public string description { get; set; }
        public Allof171[] allOf { get; set; }
    }

    public class Allof171
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyleaderboardresults
    {
        public string type { get; set; }
        public Properties339 properties { get; set; }
        public Additionalproperties119 additionalProperties { get; set; }
    }

    public class Properties339
    {
        public Focusmembershipid focusMembershipId { get; set; }
        public Focuscharacterid focusCharacterId { get; set; }
    }

    public class Focusmembershipid
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Focuscharacterid
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Additionalproperties119
    {
        public string type { get; set; }
        public Additionalproperties120 additionalProperties { get; set; }
    }

    public class Additionalproperties120
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyclanaggregatestat
    {
        public Properties340 properties { get; set; }
    }

    public class Properties340
    {
        public Mode1 mode { get; set; }
        public Statid3 statId { get; set; }
        public Value8 value { get; set; }
    }

    public class Mode1
    {
        public string description { get; set; }
        public Allof172[] allOf { get; set; }
    }

    public class Allof172
    {
        public string _ref { get; set; }
    }

    public class Statid3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Value8
    {
        public string description { get; set; }
        public Allof173[] allOf { get; set; }
    }

    public class Allof173
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyentitysearchresult
    {
        public string description { get; set; }
        public Properties341 properties { get; set; }
    }

    public class Properties341
    {
        public Suggestedwords suggestedWords { get; set; }
        public Results3 results { get; set; }
    }

    public class Suggestedwords
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items186 items { get; set; }
    }

    public class Items186
    {
        public string type { get; set; }
    }

    public class Results3
    {
        public string description { get; set; }
        public Allof174[] allOf { get; set; }
    }

    public class Allof174
    {
        public string _ref { get; set; }
    }

    public class DestinyDefinitionsDestinyentitysearchresultitem
    {
        public string description { get; set; }
        public Properties342 properties { get; set; }
    }

    public class Properties342
    {
        public Hash35 hash { get; set; }
        public Entitytype entityType { get; set; }
        public Displayproperties38 displayProperties { get; set; }
        public Weight3 weight { get; set; }
    }

    public class Hash35
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Entitytype
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Displayproperties38
    {
        public string description { get; set; }
        public Allof175[] allOf { get; set; }
    }

    public class Allof175
    {
        public string _ref { get; set; }
    }

    public class Weight3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Searchresultofdestinyentitysearchresultitem
    {
        public Properties343 properties { get; set; }
    }

    public class Properties343
    {
        public Results4 results { get; set; }
        public Totalresults3 totalResults { get; set; }
        public Hasmore3 hasMore { get; set; }
        public Query3 query { get; set; }
        public Replacementcontinuationtoken3 replacementContinuationToken { get; set; }
        public Usetotalresults3 useTotalResults { get; set; }
    }

    public class Results4
    {
        public string type { get; set; }
        public Items187 items { get; set; }
    }

    public class Items187
    {
        public string _ref { get; set; }
    }

    public class Totalresults3
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Hasmore3
    {
        public string type { get; set; }
    }

    public class Query3
    {
        public string _ref { get; set; }
    }

    public class Replacementcontinuationtoken3
    {
        public string type { get; set; }
    }

    public class Usetotalresults3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class XEnumValues74
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class DestinyHistoricalstatsDestinyhistoricalstatsbyperiod
    {
        public Properties344 properties { get; set; }
    }

    public class Properties344
    {
        public Alltime allTime { get; set; }
        public Alltimetier1 allTimeTier1 { get; set; }
        public Alltimetier2 allTimeTier2 { get; set; }
        public Alltimetier3 allTimeTier3 { get; set; }
        public Daily daily { get; set; }
        public Monthly monthly { get; set; }
    }

    public class Alltime
    {
        public string type { get; set; }
        public Additionalproperties121 additionalProperties { get; set; }
    }

    public class Additionalproperties121
    {
        public string _ref { get; set; }
    }

    public class Alltimetier1
    {
        public string type { get; set; }
        public Additionalproperties122 additionalProperties { get; set; }
    }

    public class Additionalproperties122
    {
        public string _ref { get; set; }
    }

    public class Alltimetier2
    {
        public string type { get; set; }
        public Additionalproperties123 additionalProperties { get; set; }
    }

    public class Additionalproperties123
    {
        public string _ref { get; set; }
    }

    public class Alltimetier3
    {
        public string type { get; set; }
        public Additionalproperties124 additionalProperties { get; set; }
    }

    public class Additionalproperties124
    {
        public string _ref { get; set; }
    }

    public class Daily
    {
        public string type { get; set; }
        public Items188 items { get; set; }
    }

    public class Items188
    {
        public string _ref { get; set; }
    }

    public class Monthly
    {
        public string type { get; set; }
        public Items189 items { get; set; }
    }

    public class Items189
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyhistoricalstatsperiodgroup
    {
        public Properties345 properties { get; set; }
    }

    public class Properties345
    {
        public Period1 period { get; set; }
        public Activitydetails1 activityDetails { get; set; }
        public Values5 values { get; set; }
    }

    public class Period1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Activitydetails1
    {
        public string description { get; set; }
        public Allof176[] allOf { get; set; }
    }

    public class Allof176
    {
        public string _ref { get; set; }
    }

    public class Values5
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties125 additionalProperties { get; set; }
    }

    public class Additionalproperties125
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyhistoricalstatsresults
    {
        public string type { get; set; }
        public Additionalproperties126 additionalProperties { get; set; }
    }

    public class Additionalproperties126
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyhistoricalstatsaccountresult
    {
        public Properties346 properties { get; set; }
    }

    public class Properties346
    {
        public Mergeddeletedcharacters mergedDeletedCharacters { get; set; }
        public Mergedallcharacters mergedAllCharacters { get; set; }
        public Characters1 characters { get; set; }
    }

    public class Mergeddeletedcharacters
    {
        public string _ref { get; set; }
    }

    public class Mergedallcharacters
    {
        public string _ref { get; set; }
    }

    public class Characters1
    {
        public string type { get; set; }
        public Items190 items { get; set; }
    }

    public class Items190
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyhistoricalstatswithmerged
    {
        public Properties347 properties { get; set; }
    }

    public class Properties347
    {
        public Results5 results { get; set; }
        public Merged merged { get; set; }
    }

    public class Results5
    {
        public string type { get; set; }
        public Additionalproperties127 additionalProperties { get; set; }
    }

    public class Additionalproperties127
    {
        public string _ref { get; set; }
    }

    public class Merged
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyhistoricalstatspercharacter
    {
        public Properties348 properties { get; set; }
    }

    public class Properties348
    {
        public Characterid9 characterId { get; set; }
        public Deleted deleted { get; set; }
        public Results6 results { get; set; }
        public Merged1 merged { get; set; }
    }

    public class Characterid9
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Deleted
    {
        public string type { get; set; }
    }

    public class Results6
    {
        public string type { get; set; }
        public Additionalproperties128 additionalProperties { get; set; }
    }

    public class Additionalproperties128
    {
        public string _ref { get; set; }
    }

    public class Merged1
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyactivityhistoryresults
    {
        public Properties349 properties { get; set; }
    }

    public class Properties349
    {
        public Activities3 activities { get; set; }
    }

    public class Activities3
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items191 items { get; set; }
    }

    public class Items191
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyhistoricalweaponstatsdata
    {
        public Properties350 properties { get; set; }
    }

    public class Properties350
    {
        public Weapons1 weapons { get; set; }
    }

    public class Weapons1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items192 items { get; set; }
    }

    public class Items192
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyaggregateactivityresults
    {
        public Properties351 properties { get; set; }
    }

    public class Properties351
    {
        public Activities4 activities { get; set; }
    }

    public class Activities4
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items193 items { get; set; }
    }

    public class Items193
    {
        public string _ref { get; set; }
    }

    public class DestinyHistoricalstatsDestinyaggregateactivitystats
    {
        public Properties352 properties { get; set; }
    }

    public class Properties352
    {
        public Activityhash7 activityHash { get; set; }
        public Values6 values { get; set; }
    }

    public class Activityhash7
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition130 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition130
    {
        public string _ref { get; set; }
    }

    public class Values6
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties129 additionalProperties { get; set; }
    }

    public class Additionalproperties129
    {
        public string _ref { get; set; }
    }

    public class DestinyMilestonesDestinymilestonecontent
    {
        public string description { get; set; }
        public Properties353 properties { get; set; }
    }

    public class Properties353
    {
        public About2 about { get; set; }
        public Status1 status { get; set; }
        public Tips tips { get; set; }
        public Itemcategories itemCategories { get; set; }
    }

    public class About2
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Status1
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Tips
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items194 items { get; set; }
    }

    public class Items194
    {
        public string type { get; set; }
    }

    public class Itemcategories
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items195 items { get; set; }
    }

    public class Items195
    {
        public string _ref { get; set; }
    }

    public class DestinyMilestonesDestinymilestonecontentitemcategory
    {
        public string description { get; set; }
        public Properties354 properties { get; set; }
    }

    public class Properties354
    {
        public Title2 title { get; set; }
        public Itemhashes itemHashes { get; set; }
    }

    public class Title2
    {
        public string type { get; set; }
    }

    public class Itemhashes
    {
        public string type { get; set; }
        public Items196 items { get; set; }
        public XMappedDefinition131 xmappeddefinition { get; set; }
    }

    public class Items196
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition131
    {
        public string _ref { get; set; }
    }

    public class DestinyMilestonesDestinypublicmilestone
    {
        public string description { get; set; }
        public Properties355 properties { get; set; }
    }

    public class Properties355
    {
        public Milestonehash1 milestoneHash { get; set; }
        public Availablequests1 availableQuests { get; set; }
        public Vendorhashes1 vendorHashes { get; set; }
        public Startdate1 startDate { get; set; }
        public Enddate1 endDate { get; set; }
    }

    public class Milestonehash1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition132 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition132
    {
        public string _ref { get; set; }
    }

    public class Availablequests1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items197 items { get; set; }
    }

    public class Items197
    {
        public string _ref { get; set; }
    }

    public class Vendorhashes1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items198 items { get; set; }
    }

    public class Items198
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Startdate1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Enddate1
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyMilestonesDestinypublicmilestonequest
    {
        public Properties356 properties { get; set; }
    }

    public class Properties356
    {
        public Questitemhash2 questItemHash { get; set; }
        public Activity1 activity { get; set; }
        public Challenges2 challenges { get; set; }
    }

    public class Questitemhash2
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition133 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition133
    {
        public string _ref { get; set; }
    }

    public class Activity1
    {
        public string description { get; set; }
        public Allof177[] allOf { get; set; }
    }

    public class Allof177
    {
        public string _ref { get; set; }
    }

    public class Challenges2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items199 items { get; set; }
    }

    public class Items199
    {
        public string _ref { get; set; }
    }

    public class DestinyMilestonesDestinypublicmilestoneactivity
    {
        public string description { get; set; }
        public Properties357 properties { get; set; }
    }

    public class Properties357
    {
        public Activityhash8 activityHash { get; set; }
        public Modifierhashes1 modifierHashes { get; set; }
        public Variants2 variants { get; set; }
    }

    public class Activityhash8
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition134 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition134
    {
        public string _ref { get; set; }
    }

    public class Modifierhashes1
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items200 items { get; set; }
        public XMappedDefinition135 xmappeddefinition { get; set; }
    }

    public class Items200
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition135
    {
        public string _ref { get; set; }
    }

    public class Variants2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items201 items { get; set; }
    }

    public class Items201
    {
        public string _ref { get; set; }
    }

    public class DestinyMilestonesDestinypublicmilestoneactivityvariant
    {
        public string description { get; set; }
        public Properties358 properties { get; set; }
    }

    public class Properties358
    {
        public Activityhash9 activityHash { get; set; }
    }

    public class Activityhash9
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class DestinyMilestonesDestinypublicmilestonechallenge
    {
        public string description { get; set; }
        public Properties359 properties { get; set; }
    }

    public class Properties359
    {
        public Objectivehash3 objectiveHash { get; set; }
        public Activityhash10 activityHash { get; set; }
    }

    public class Objectivehash3
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition136 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition136
    {
        public string _ref { get; set; }
    }

    public class Activityhash10
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
        public XMappedDefinition137 xmappeddefinition { get; set; }
    }

    public class XMappedDefinition137
    {
        public string _ref { get; set; }
    }

    public class ForumCommunitycontentsortmode
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues75[] xenumvalues { get; set; }
    }

    public class XEnumValues75
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class CommunityCommunitystatussort
    {
        public string format { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues76[] xenumvalues { get; set; }
    }

    public class XEnumValues76
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class CommunityCommunitylivestatus
    {
        public Properties360 properties { get; set; }
    }

    public class Properties360
    {
        public Datestatusupdated dateStatusUpdated { get; set; }
        public Url1 url { get; set; }
        public Partnershipidentifier partnershipIdentifier { get; set; }
        public Partnershiptype partnershipType { get; set; }
        public Thumbnail1 thumbnail { get; set; }
        public Thumbnailsmall thumbnailSmall { get; set; }
        public Thumbnaillarge thumbnailLarge { get; set; }
        public Destinycharacterid destinyCharacterId { get; set; }
        public Userinfo1 userInfo { get; set; }
        public Currentactivityhash1 currentActivityHash { get; set; }
        public Datelastplayed2 dateLastPlayed { get; set; }
        public Datestreamstarted dateStreamStarted { get; set; }
        public Locale3 locale { get; set; }
        public Currentviewers currentViewers { get; set; }
        public Followers followers { get; set; }
        public Overallviewers overallViewers { get; set; }
        public Isfeatured isFeatured { get; set; }
        public Title3 title { get; set; }
        public Activitymodehash1 activityModeHash { get; set; }
        public Datefeatured dateFeatured { get; set; }
        public Trendingvalue trendingValue { get; set; }
        public Issubscribable isSubscribable { get; set; }
    }

    public class Datestatusupdated
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Url1
    {
        public string type { get; set; }
    }

    public class Partnershipidentifier
    {
        public string type { get; set; }
    }

    public class Partnershiptype
    {
        public string _ref { get; set; }
    }

    public class Thumbnail1
    {
        public string type { get; set; }
    }

    public class Thumbnailsmall
    {
        public string type { get; set; }
    }

    public class Thumbnaillarge
    {
        public string type { get; set; }
    }

    public class Destinycharacterid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Userinfo1
    {
        public string _ref { get; set; }
    }

    public class Currentactivityhash1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Datelastplayed2
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Datestreamstarted
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Locale3
    {
        public string type { get; set; }
    }

    public class Currentviewers
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Followers
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Overallviewers
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Isfeatured
    {
        public string type { get; set; }
    }

    public class Title3
    {
        public string type { get; set; }
    }

    public class Activitymodehash1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Datefeatured
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Trendingvalue
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Issubscribable
    {
        public string type { get; set; }
    }

    public class Searchresultofcommunitylivestatus
    {
        public Properties361 properties { get; set; }
    }

    public class Properties361
    {
        public Results7 results { get; set; }
        public Totalresults4 totalResults { get; set; }
        public Hasmore4 hasMore { get; set; }
        public Query4 query { get; set; }
        public Replacementcontinuationtoken4 replacementContinuationToken { get; set; }
        public Usetotalresults4 useTotalResults { get; set; }
    }

    public class Results7
    {
        public string type { get; set; }
        public Items202 items { get; set; }
    }

    public class Items202
    {
        public string _ref { get; set; }
    }

    public class Totalresults4
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Hasmore4
    {
        public string type { get; set; }
    }

    public class Query4
    {
        public string _ref { get; set; }
    }

    public class Replacementcontinuationtoken4
    {
        public string type { get; set; }
    }

    public class Usetotalresults4
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class TrendingTrendingcategories
    {
        public Properties362 properties { get; set; }
    }

    public class Properties362
    {
        public Categories3 categories { get; set; }
    }

    public class Categories3
    {
        public string type { get; set; }
        public Items203 items { get; set; }
    }

    public class Items203
    {
        public string _ref { get; set; }
    }

    public class TrendingTrendingcategory
    {
        public Properties363 properties { get; set; }
    }

    public class Properties363
    {
        public Categoryname categoryName { get; set; }
        public Entries3 entries { get; set; }
        public Categoryid1 categoryId { get; set; }
    }

    public class Categoryname
    {
        public string type { get; set; }
    }

    public class Entries3
    {
        public string _ref { get; set; }
    }

    public class Categoryid1
    {
        public string type { get; set; }
    }

    public class TrendingTrendingentry
    {
        public string description { get; set; }
        public Properties364 properties { get; set; }
    }

    public class Properties364
    {
        public Weight4 weight { get; set; }
        public Isfeatured1 isFeatured { get; set; }
        public Identifier3 identifier { get; set; }
        public Entitytype1 entityType { get; set; }
        public Displayname3 displayName { get; set; }
        public Tagline tagline { get; set; }
        public Image1 image { get; set; }
        public Startdate2 startDate { get; set; }
        public Enddate2 endDate { get; set; }
        public Link link { get; set; }
        public Webmvideo webmVideo { get; set; }
        public Mp4video mp4Video { get; set; }
        public Featureimage featureImage { get; set; }
    }

    public class Weight4
    {
        public string format { get; set; }
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Isfeatured1
    {
        public string type { get; set; }
    }

    public class Identifier3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Entitytype1
    {
        public string description { get; set; }
        public Allof178[] allOf { get; set; }
    }

    public class Allof178
    {
        public string _ref { get; set; }
    }

    public class Displayname3
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Tagline
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Image1
    {
        public string type { get; set; }
    }

    public class Startdate2
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Enddate2
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Link
    {
        public string type { get; set; }
    }

    public class Webmvideo
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Mp4video
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class Featureimage
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class TrendingTrendingentrytype
    {
        public string format { get; set; }
        public string description { get; set; }
        public string[] _enum { get; set; }
        public string type { get; set; }
        public XEnumValues77[] xenumvalues { get; set; }
    }

    public class XEnumValues77
    {
        public string numericValue { get; set; }
        public string identifier { get; set; }
    }

    public class Searchresultoftrendingentry
    {
        public Properties365 properties { get; set; }
    }

    public class Properties365
    {
        public Results8 results { get; set; }
        public Totalresults5 totalResults { get; set; }
        public Hasmore5 hasMore { get; set; }
        public Query5 query { get; set; }
        public Replacementcontinuationtoken5 replacementContinuationToken { get; set; }
        public Usetotalresults5 useTotalResults { get; set; }
    }

    public class Results8
    {
        public string type { get; set; }
        public Items204 items { get; set; }
    }

    public class Items204
    {
        public string _ref { get; set; }
    }

    public class Totalresults5
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Hasmore5
    {
        public string type { get; set; }
    }

    public class Query5
    {
        public string _ref { get; set; }
    }

    public class Replacementcontinuationtoken5
    {
        public string type { get; set; }
    }

    public class Usetotalresults5
    {
        public string description { get; set; }
        public string type { get; set; }
    }

    public class TrendingTrendingdetail
    {
        public Properties366 properties { get; set; }
    }

    public class Properties366
    {
        public Identifier4 identifier { get; set; }
        public Entitytype2 entityType { get; set; }
        public News news { get; set; }
        public Support support { get; set; }
        public Destinyitem destinyItem { get; set; }
        public Destinyactivity destinyActivity { get; set; }
        public Destinyritual destinyRitual { get; set; }
        public Creation creation { get; set; }
        public Stream stream { get; set; }
    }

    public class Identifier4
    {
        public string type { get; set; }
    }

    public class Entitytype2
    {
        public string _ref { get; set; }
    }

    public class News
    {
        public string _ref { get; set; }
    }

    public class Support
    {
        public string _ref { get; set; }
    }

    public class Destinyitem
    {
        public string _ref { get; set; }
    }

    public class Destinyactivity
    {
        public string _ref { get; set; }
    }

    public class Destinyritual
    {
        public string _ref { get; set; }
    }

    public class Creation
    {
        public string _ref { get; set; }
    }

    public class Stream
    {
        public string _ref { get; set; }
    }

    public class TrendingTrendingentrynews
    {
        public Properties367 properties { get; set; }
    }

    public class Properties367
    {
        public Article article { get; set; }
    }

    public class Article
    {
        public string _ref { get; set; }
    }

    public class ContentContentitempubliccontract
    {
        public Properties368 properties { get; set; }
    }

    public class Properties368
    {
        public Contentid contentId { get; set; }
        public Ctype cType { get; set; }
        public Cmspath cmsPath { get; set; }
        public Creationdate1 creationDate { get; set; }
        public Modifydate modifyDate { get; set; }
        public Allowcomments allowComments { get; set; }
        public Hasagegate hasAgeGate { get; set; }
        public Minimumage minimumAge { get; set; }
        public Ratingimagepath ratingImagePath { get; set; }
        public Author author { get; set; }
        public Autoenglishpropertyfallback autoEnglishPropertyFallback { get; set; }
        public Properties369 properties { get; set; }
        public Representations representations { get; set; }
        public Tags1 tags { get; set; }
        public Commentsummary commentSummary { get; set; }
    }

    public class Contentid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Ctype
    {
        public string type { get; set; }
    }

    public class Cmspath
    {
        public string type { get; set; }
    }

    public class Creationdate1
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Modifydate
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Allowcomments
    {
        public string type { get; set; }
    }

    public class Hasagegate
    {
        public string type { get; set; }
    }

    public class Minimumage
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Ratingimagepath
    {
        public string type { get; set; }
    }

    public class Author
    {
        public string _ref { get; set; }
    }

    public class Autoenglishpropertyfallback
    {
        public string type { get; set; }
    }

    public class Properties369
    {
        public string description { get; set; }
        public string type { get; set; }
        public Additionalproperties130 additionalProperties { get; set; }
    }

    public class Additionalproperties130
    {
        public string type { get; set; }
    }

    public class Representations
    {
        public string type { get; set; }
        public Items205 items { get; set; }
    }

    public class Items205
    {
        public string _ref { get; set; }
    }

    public class Tags1
    {
        public string type { get; set; }
        public Items206 items { get; set; }
    }

    public class Items206
    {
        public string type { get; set; }
    }

    public class Commentsummary
    {
        public string _ref { get; set; }
    }

    public class ContentContentrepresentation
    {
        public Properties370 properties { get; set; }
    }

    public class Properties370
    {
        public Name9 name { get; set; }
        public Path2 path { get; set; }
        public Validationstring validationString { get; set; }
    }

    public class Name9
    {
        public string type { get; set; }
    }

    public class Path2
    {
        public string type { get; set; }
    }

    public class Validationstring
    {
        public string type { get; set; }
    }

    public class ContentCommentsummary
    {
        public Properties371 properties { get; set; }
    }

    public class Properties371
    {
        public Topicid2 topicId { get; set; }
        public Commentcount commentCount { get; set; }
    }

    public class Topicid2
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Commentcount
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class TrendingTrendingentrysupportarticle
    {
        public Properties372 properties { get; set; }
    }

    public class Properties372
    {
        public Article1 article { get; set; }
    }

    public class Article1
    {
        public string _ref { get; set; }
    }

    public class TrendingTrendingentrydestinyitem
    {
        public Properties373 properties { get; set; }
    }

    public class Properties373
    {
        public Itemhash10 itemHash { get; set; }
    }

    public class Itemhash10
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class TrendingTrendingentrydestinyactivity
    {
        public Properties374 properties { get; set; }
    }

    public class Properties374
    {
        public Activityhash11 activityHash { get; set; }
        public Status2 status { get; set; }
    }

    public class Activityhash11
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Status2
    {
        public string _ref { get; set; }
    }

    public class DestinyActivitiesDestinypublicactivitystatus
    {
        public string description { get; set; }
        public Properties375 properties { get; set; }
    }

    public class Properties375
    {
        public Challengeobjectivehashes challengeObjectiveHashes { get; set; }
        public Modifierhashes2 modifierHashes { get; set; }
        public Rewardtooltipitems rewardTooltipItems { get; set; }
    }

    public class Challengeobjectivehashes
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items207 items { get; set; }
        public XMappedDefinition138 xmappeddefinition { get; set; }
    }

    public class Items207
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition138
    {
        public string _ref { get; set; }
    }

    public class Modifierhashes2
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items208 items { get; set; }
        public XMappedDefinition139 xmappeddefinition { get; set; }
    }

    public class Items208
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class XMappedDefinition139
    {
        public string _ref { get; set; }
    }

    public class Rewardtooltipitems
    {
        public string description { get; set; }
        public string type { get; set; }
        public Items209 items { get; set; }
    }

    public class Items209
    {
        public string _ref { get; set; }
    }

    public class TrendingTrendingentrydestinyritual
    {
        public Properties376 properties { get; set; }
    }

    public class Properties376
    {
        public Image2 image { get; set; }
        public Icon7 icon { get; set; }
        public Title4 title { get; set; }
        public Subtitle2 subtitle { get; set; }
        public Datestart dateStart { get; set; }
        public Dateend dateEnd { get; set; }
        public Milestonedetails milestoneDetails { get; set; }
        public Eventcontent eventContent { get; set; }
    }

    public class Image2
    {
        public string type { get; set; }
    }

    public class Icon7
    {
        public string type { get; set; }
    }

    public class Title4
    {
        public string type { get; set; }
    }

    public class Subtitle2
    {
        public string type { get; set; }
    }

    public class Datestart
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Dateend
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Milestonedetails
    {
        public string description { get; set; }
        public Allof179[] allOf { get; set; }
    }

    public class Allof179
    {
        public string _ref { get; set; }
    }

    public class Eventcontent
    {
        public string description { get; set; }
        public Allof180[] allOf { get; set; }
    }

    public class Allof180
    {
        public string _ref { get; set; }
    }

    public class TrendingTrendingentrycommunitycreation
    {
        public Properties377 properties { get; set; }
    }

    public class Properties377
    {
        public Media media { get; set; }
        public Title5 title { get; set; }
        public Author1 author { get; set; }
        public Authormembershipid authorMembershipId { get; set; }
        public Postid postId { get; set; }
        public Body body { get; set; }
        public Upvotes upvotes { get; set; }
    }

    public class Media
    {
        public string type { get; set; }
    }

    public class Title5
    {
        public string type { get; set; }
    }

    public class Author1
    {
        public string type { get; set; }
    }

    public class Authormembershipid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Postid
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class Body
    {
        public string type { get; set; }
    }

    public class Upvotes
    {
        public string format { get; set; }
        public string type { get; set; }
    }

    public class TrendingTrendingentrycommunitystream
    {
        public Properties378 properties { get; set; }
    }

    public class Properties378
    {
        public Image3 image { get; set; }
        public Title6 title { get; set; }
        public Partnershipidentifier1 partnershipIdentifier { get; set; }
        public Partnershiptype1 partnershipType { get; set; }
    }

    public class Image3
    {
        public string type { get; set; }
    }

    public class Title6
    {
        public string type { get; set; }
    }

    public class Partnershipidentifier1
    {
        public string type { get; set; }
    }

    public class Partnershiptype1
    {
        public string _ref { get; set; }
    }

    public class Securitydefinitions
    {
        public Apikey apiKey { get; set; }
        public Oauth2 oauth2 { get; set; }
    }

    public class Apikey
    {
        public string type { get; set; }
        public string description { get; set; }
        public string name { get; set; }
        public string _in { get; set; }
    }

    public class Oauth2
    {
        public string type { get; set; }
        public string description { get; set; }
        public string authorizationUrl { get; set; }
        public string tokenUrl { get; set; }
        public string flow { get; set; }
        public Scopes scopes { get; set; }
    }

    public class Scopes
    {
        public string ReadBasicUserProfile { get; set; }
        public string ReadGroups { get; set; }
        public string WriteGroups { get; set; }
        public string AdminGroups { get; set; }
        public string BnetWrite { get; set; }
        public string MoveEquipDestinyItems { get; set; }
        public string ReadDestinyInventoryAndVault { get; set; }
        public string ReadUserData { get; set; }
        public string EditUserData { get; set; }
        public string ReadDestinyVendorsAndAdvisors { get; set; }
        public string ReadAndApplyTokens { get; set; }
    }

    public class Externaldocs
    {
        public string description { get; set; }
        public string url { get; set; }
    }

    public class Tag
    {
        public string name { get; set; }
        public string description { get; set; }
    }


}
