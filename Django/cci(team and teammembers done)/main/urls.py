from django.conf.urls import url
from . import views
app_name = 'main'

urlpatterns = [
        url(r'^$', views.IndexView.as_view(), name='index'),
        url(r'^(?P<pk>[0-9]+)$', views.DetailView.as_view(), name='details'),
        url(r'^main/add/$', views.TeamMemberCreate.as_view(), name='TeamMember'),
        url(r'^main/(?P<pk>[0-9]+)/delete/$', views.TeamMemberDelete.as_view(), name = 'TeamMember-delete'),
        url(r'^main/teams/add/$', views.TeamsCreate.as_view(), name='Teams'),
        url(r'^main/teams/(?P<pk>[0-9]+)$', views.TeamDetailView.as_view(), name='TeamDetails'),
        url(r'^main/teams/$', views.TeamView.as_view(), name='AllTeams'),
        url(r'^main/(?P<pk>[0-9]+)/teams/delete/', views.TeamsDelete.as_view(), name = 'Teams-delete'),
        url(r'^(?P<pk>[0-9]+)$', views.TeamMemberDetailView.as_view(), name='TeamMemberDetails'),
       # url(r'^main/Groups/add/$', views.GroupCreate.as_view(), name='Groups'),
        ]