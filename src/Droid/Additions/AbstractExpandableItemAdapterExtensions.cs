using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

using Android.App;
using Android.Content;
using Android.Database;
using Android.OS;
using Android.Runtime;
using Android.Views;
using Android.Widget;
using Object = Java.Lang.Object;

namespace Com.H6ah4i.Android.Widget.Advrecyclerview.Utils
{
    public abstract partial class AbstractExpandableItemAdapter : global::Android.Support.V7.Widget.RecyclerView.Adapter, global::Com.H6ah4i.Android.Widget.Advrecyclerview.Expandable.IExpandableItemAdapter
    {

        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.expandable']/interface[@name='ExpandableItemAdapter']/method[@name='onCreateChildViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
        [Register("onCreateChildViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetOnCreateChildViewHolder_Landroid_view_ViewGroup_IHandler:Com.H6ah4i.Android.Widget.Advrecyclerview.Expandable.IExpandableItemAdapterInvoker, Xamarin.Bindings.AdvancedRecyclerView")]
        public abstract global::Java.Lang.Object OnCreateChildViewHolder(global::Android.Views.ViewGroup parent, int viewType);

        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.expandable']/interface[@name='ExpandableItemAdapter']/method[@name='onCreateGroupViewHolder' and count(parameter)=2 and parameter[1][@type='android.view.ViewGroup'] and parameter[2][@type='int']]"
        [Register("onCreateGroupViewHolder", "(Landroid/view/ViewGroup;I)Landroid/support/v7/widget/RecyclerView$ViewHolder;", "GetOnCreateGroupViewHolder_Landroid_view_ViewGroup_IHandler:Com.H6ah4i.Android.Widget.Advrecyclerview.Expandable.IExpandableItemAdapterInvoker, Xamarin.Bindings.AdvancedRecyclerView")]
        public abstract global::Java.Lang.Object OnCreateGroupViewHolder(global::Android.Views.ViewGroup parent, int viewType);

        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.expandable']/interface[@name='ExpandableItemAdapter']/method[@name='onBindChildViewHolder' and count(parameter)=4 and parameter[1][@type='CVH'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int']]"
        [Register("onBindChildViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;III)V", "GetOnBindChildViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIIHandler:Com.H6ah4i.Android.Widget.Advrecyclerview.Expandable.IExpandableItemAdapterInvoker, Xamarin.Bindings.AdvancedRecyclerView")]
        public abstract void OnBindChildViewHolder(global::Java.Lang.Object viewHolder, int groupPosition, int childPosition, int viewType);

        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.expandable']/interface[@name='ExpandableItemAdapter']/method[@name='onBindGroupViewHolder' and count(parameter)=3 and parameter[1][@type='GVH'] and parameter[2][@type='int'] and parameter[3][@type='int']]"
        [Register("onBindGroupViewHolder", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;II)V", "GetOnBindGroupViewHolder_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIHandler:Com.H6ah4i.Android.Widget.Advrecyclerview.Expandable.IExpandableItemAdapterInvoker, Xamarin.Bindings.AdvancedRecyclerView")]
        public abstract void OnBindGroupViewHolder(global::Java.Lang.Object viewHolder, int groupPosition, int viewType);

        // Metadata.xml XPath method reference: path="/api/package[@name='com.h6ah4i.android.widget.advrecyclerview.expandable']/interface[@name='ExpandableItemAdapter']/method[@name='onCheckCanExpandOrCollapseGroup' and count(parameter)=5 and parameter[1][@type='GVH'] and parameter[2][@type='int'] and parameter[3][@type='int'] and parameter[4][@type='int'] and parameter[5][@type='boolean']]"
        [Register("onCheckCanExpandOrCollapseGroup", "(Landroid/support/v7/widget/RecyclerView$ViewHolder;IIIZ)Z", "GetOnCheckCanExpandOrCollapseGroup_Landroid_support_v7_widget_RecyclerView_ViewHolder_IIIZHandler:Com.H6ah4i.Android.Widget.Advrecyclerview.Expandable.IExpandableItemAdapterInvoker, Xamarin.Bindings.AdvancedRecyclerView")]
        public abstract bool OnCheckCanExpandOrCollapseGroup(global::Java.Lang.Object holder, int groupPosition, int x, int y, bool expand);
    }

   
}