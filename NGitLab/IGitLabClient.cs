﻿namespace NGitLab
{
    public interface IGitLabClient
    {
        IUserClient Users { get; }

        IProjectClient Projects { get; }

        IIssueClient Issues { get; }

        IGroupsClient Groups { get; }

        IGlobalJobClient Jobs { get; }

        ILabelClient Labels { get; }

        IRunnerClient Runners { get; }

        IMergeRequestClient MergeRequests { get; }

        ILintClient Lint { get; }

        /// <summary>
        /// All the user events of GitLab (can be scoped for the current user).
        /// </summary>
        IEventClient GetEvents();

        /// <summary>
        /// Returns the events done by the specified user.
        /// </summary>
        IEventClient GetUserEvents(int userId);

        /// <summary>
        /// Returns the events that occurred in the specified project.
        /// </summary>
        /// <returns></returns>
        IEventClient GetProjectEvents(int projectId);

        IRepositoryClient GetRepository(int projectId);

        ICommitClient GetCommits(int projectId);

        ICommitStatusClient GetCommitStatus(int projectId);

        IPipelineClient GetPipelines(int projectId);

        ITriggerClient GetTriggers(int projectId);

        IJobClient GetJobs(int projectId);

        IMergeRequestClient GetMergeRequest(int projectId);

        IMilestoneClient GetMilestone(int projectId);

        IMilestoneClient GetGroupMilestone(int groupId);

        IReleaseClient GetReleases(int projectId);

        IMembersClient Members { get; }

        IVersionClient Version { get; }

        INamespacesClient Namespaces { get; }

        ISnippetClient Snippets { get; }

        ISystemHookClient SystemHooks { get; }

        IDeploymentClient Deployments { get; }

        IEpicClient Epics { get; }

        IGraphQLClient GraphQL { get; }

        ISearchClient AdvancedSearch { get; }

        IProjectIssueNoteClient GetProjectIssueNoteClient(int projectId);

        IEnvironmentClient GetEnvironmentClient(int projectId);

        IClusterClient GetClusterClient(int projectId);

        IWikiClient GetWikiClient(int projectId);

        IProjectBadgeClient GetProjectBadgeClient(int projectId);

        IGroupBadgeClient GetGroupBadgeClient(int groupId);

        IProjectVariableClient GetProjectVariableClient(int projectId);

        IGroupVariableClient GetGroupVariableClient(int groupId);

        IProjectLevelApprovalRulesClient GetProjectLevelApprovalRulesClient(int projectId);

        IProtectedBranchClient GetProtectedBranchClient(int projectId);

        public ISearchClient GetGroupSearchClient(int groupId);

        public ISearchClient GetProjectSearchClient(int projectId);
    }
}
