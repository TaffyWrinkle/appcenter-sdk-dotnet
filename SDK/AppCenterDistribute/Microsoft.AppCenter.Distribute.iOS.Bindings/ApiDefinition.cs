// Copyright (c) Microsoft Corporation. All rights reserved.
// Licensed under the MIT License.

using Foundation;

namespace Microsoft.AppCenter.Distribute.iOS.Bindings
{
    // @interface MSDistribute : MSService
    [BaseType(typeof(NSObject))]
    interface MSDistribute
    {
        // +(void)setEnabled:(BOOL)isEnabled;
        [Static]
        [Export("setEnabled:")]
        void SetEnabled(bool isEnabled);

        // +(BOOL)isEnabled;
        [Static]
        [Export("isEnabled")]
        bool IsEnabled();

        // + (void)setApiUrl:(NSString *)apiUrl;
        [Static]
        [Export("setApiUrl:")]
        void SetApiUrl(string apiUrl);

        // + (void)setInstallUrl:(NSString *)installUrl;
        [Static]
        [Export("setInstallUrl:")]
        void SetInstallUrl(string installUrl);

        // + (void)openURL:(NSURL *)url;
        [Static]
        [Export("openURL:")]
        void OpenUrl(NSUrl url);

        // + (void)setDelegate:(id<MSDistributeDelegate>)delegate;
        [Static]
        [Export("setDelegate:")]
        void SetDelegate(MSDistributeDelegate distributeDelegate);

        // + (void)notifyUpdateAction:(MSUpdateAction)action;
        [Static]
        [Export("notifyUpdateAction:")]
        void NotifyUpdateAction(MSUpdateAction action);

        // + (void)setUpdateTrack:(MSUpdateTrack)updateTrack;
        [Static]
        [Export("setUpdateTrack:")]
        void SetUpdateTrack(MSUpdateTrack updateTrack);

        // + (MSUpdateTrack)updateTrack;
        [Static]
        [Export("updateTrack")]
        MSUpdateTrack GetUpdateTrack();

        // +(void)resetSharedInstance;
        [Static]
        [Export("resetSharedInstance")]
        void ResetSharedInstance();

        // + (void)checkForUpdate;
        [Static]
        [Export("checkForUpdate")]
        void CheckForUpdate();

        // + (void)disableAutomaticCheckForUpdate;
        [Static]
        [Export("disableAutomaticCheckForUpdate")]
        void DisableAutomaticCheckForUpdate();
    }

    // @protocol MSDistributeDelegate <NSObject>
    [Protocol, Model]
    [BaseType(typeof(NSObject))]
    interface MSDistributeDelegate
    {
        // @optional - (BOOL)distribute:(MSDistribute *)distribute releaseAvailableWithDetails:(MSReleaseDetails *)details;
        [Export("distribute:releaseAvailableWithDetails:")]
        bool OnReleaseAvailable(MSDistribute distribute, MSReleaseDetails details);
    }

    // @interface MSReleaseDetails : NSObject
    [BaseType(typeof(NSObject))]
    interface MSReleaseDetails
    {
        // @property(nonatomic, copy) NSNumber *id;
        [Export("id")]
        int Id { get; }

        // @property(nonatomic, copy) NSString *version;
        [Export("version")]
        string Version { get; }

        // @property(nonatomic, copy) NSString *shortVersion;
        [Export("shortVersion")]
        string ShortVersion { get; }

        // @property(nonatomic, copy) NSString *releaseNotes;
        [Export("releaseNotes")]
        string ReleaseNotes { get; }

        // @property(nonatomic) NSURL* releaseNotesUrl;
        [Export("releaseNotesUrl")]
        NSUrl ReleaseNotesUrl { get; }

        // @property(nonatomic, getter=isMandatoryUpdate) BOOL mandatoryUpdate;
        [Export("isMandatoryUpdate")]
        bool MandatoryUpdate { get; }
    }
}
