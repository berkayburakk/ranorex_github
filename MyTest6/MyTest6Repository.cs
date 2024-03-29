﻿///////////////////////////////////////////////////////////////////////////////
//
// This file was automatically generated by RANOREX.
// DO NOT MODIFY THIS FILE! It is regenerated by the designer.
// All your modifications will be lost!
// http://www.ranorex.com
//
///////////////////////////////////////////////////////////////////////////////

using System;
using System.Collections.Generic;
using System.Text;
using System.Drawing;
using Ranorex;
using Ranorex.Core;
using Ranorex.Core.Repository;
using Ranorex.Core.Testing;

namespace MyTest6
{
#pragma warning disable 0436 //(CS0436) The type 'type' in 'assembly' conflicts with the imported type 'type2' in 'assembly'. Using the type defined in 'assembly'.
    /// <summary>
    /// The class representing the MyTest6Repository element repository.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    [RepositoryFolder("efc64dc3-d0e9-49cf-8310-049a642fb789")]
    public partial class MyTest6Repository : RepoGenBaseFolder
    {
        static MyTest6Repository instance = new MyTest6Repository();
        MyTest6RepositoryFolders.RxMainFrameAppFolder _rxmainframe;

        /// <summary>
        /// Gets the singleton class instance representing the MyTest6Repository element repository.
        /// </summary>
        [RepositoryFolder("efc64dc3-d0e9-49cf-8310-049a642fb789")]
        public static MyTest6Repository Instance
        {
            get { return instance; }
        }

        /// <summary>
        /// Repository class constructor.
        /// </summary>
        public MyTest6Repository() 
            : base("MyTest6Repository", "/", null, 0, false, "efc64dc3-d0e9-49cf-8310-049a642fb789", ".\\RepositoryImages\\MyTest6Repositoryefc64dc3.rximgres")
        {
            _rxmainframe = new MyTest6RepositoryFolders.RxMainFrameAppFolder(this);
        }

#region Variables

#endregion

        /// <summary>
        /// The Self item info.
        /// </summary>
        [RepositoryItemInfo("efc64dc3-d0e9-49cf-8310-049a642fb789")]
        public virtual RepoItemInfo SelfInfo
        {
            get
            {
                return _selfInfo;
            }
        }

        /// <summary>
        /// The RxMainFrame folder.
        /// </summary>
        [RepositoryFolder("9fa4d558-b92b-4e86-b743-460ad419ea14")]
        public virtual MyTest6RepositoryFolders.RxMainFrameAppFolder RxMainFrame
        {
            get { return _rxmainframe; }
        }
    }

    /// <summary>
    /// Inner folder classes.
    /// </summary>
    [System.CodeDom.Compiler.GeneratedCode("Ranorex", global::Ranorex.Core.Constants.CodeGenVersion)]
    public partial class MyTest6RepositoryFolders
    {
        /// <summary>
        /// The RxMainFrameAppFolder folder.
        /// </summary>
        [RepositoryFolder("9fa4d558-b92b-4e86-b743-460ad419ea14")]
        public partial class RxMainFrameAppFolder : RepoGenBaseFolder
        {
            RepoItemInfo _enteryournameInfo;
            RepoItemInfo _btnsubmitusernameInfo;
            RepoItemInfo _rxbuttonexitInfo;

            /// <summary>
            /// Creates a new RxMainFrame  folder.
            /// </summary>
            public RxMainFrameAppFolder(RepoGenBaseFolder parentFolder) :
                    base("RxMainFrame", "/form[@controlname='RxMainFrame']", parentFolder, 30000, null, true, "9fa4d558-b92b-4e86-b743-460ad419ea14", "")
            {
                _enteryournameInfo = new RepoItemInfo(this, "EnterYourName", "?/?/tabpage[@controlname='RxTabIntroduction']/?/?/text[@accessiblename='Enter your name']", 30000, null, "9efbd563-8ffa-4c3c-bb0a-c36eaa71e498");
                _btnsubmitusernameInfo = new RepoItemInfo(this, "BtnSubmitUserName", "?/?/tabpage[@controlname='RxTabIntroduction']/button[@controlname='btnSubmitUserName']", 30000, null, "42e678a0-fb01-49ab-9d15-8610934aafe9");
                _rxbuttonexitInfo = new RepoItemInfo(this, "RxButtonExit", "button[@controlname='RxButtonExit']", 30000, null, "bb7808d6-c360-4714-b4d7-99eb8716b7f3");
            }

            /// <summary>
            /// The Self item.
            /// </summary>
            [RepositoryItem("9fa4d558-b92b-4e86-b743-460ad419ea14")]
            public virtual Ranorex.Form Self
            {
                get
                {
                    return _selfInfo.CreateAdapter<Ranorex.Form>(true);
                }
            }

            /// <summary>
            /// The Self item info.
            /// </summary>
            [RepositoryItemInfo("9fa4d558-b92b-4e86-b743-460ad419ea14")]
            public virtual RepoItemInfo SelfInfo
            {
                get
                {
                    return _selfInfo;
                }
            }

            /// <summary>
            /// The EnterYourName item.
            /// </summary>
            [RepositoryItem("9efbd563-8ffa-4c3c-bb0a-c36eaa71e498")]
            public virtual Ranorex.Text EnterYourName
            {
                get
                {
                    return _enteryournameInfo.CreateAdapter<Ranorex.Text>(true);
                }
            }

            /// <summary>
            /// The EnterYourName item info.
            /// </summary>
            [RepositoryItemInfo("9efbd563-8ffa-4c3c-bb0a-c36eaa71e498")]
            public virtual RepoItemInfo EnterYourNameInfo
            {
                get
                {
                    return _enteryournameInfo;
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item.
            /// </summary>
            [RepositoryItem("42e678a0-fb01-49ab-9d15-8610934aafe9")]
            public virtual Ranorex.Button BtnSubmitUserName
            {
                get
                {
                    return _btnsubmitusernameInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The BtnSubmitUserName item info.
            /// </summary>
            [RepositoryItemInfo("42e678a0-fb01-49ab-9d15-8610934aafe9")]
            public virtual RepoItemInfo BtnSubmitUserNameInfo
            {
                get
                {
                    return _btnsubmitusernameInfo;
                }
            }

            /// <summary>
            /// The RxButtonExit item.
            /// </summary>
            [RepositoryItem("bb7808d6-c360-4714-b4d7-99eb8716b7f3")]
            public virtual Ranorex.Button RxButtonExit
            {
                get
                {
                    return _rxbuttonexitInfo.CreateAdapter<Ranorex.Button>(true);
                }
            }

            /// <summary>
            /// The RxButtonExit item info.
            /// </summary>
            [RepositoryItemInfo("bb7808d6-c360-4714-b4d7-99eb8716b7f3")]
            public virtual RepoItemInfo RxButtonExitInfo
            {
                get
                {
                    return _rxbuttonexitInfo;
                }
            }
        }

    }
#pragma warning restore 0436
}
