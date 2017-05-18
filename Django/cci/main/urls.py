from django.conf.urls import url
from . import views
app_name = 'main'

urlpatterns = [
        url(r'^$', views.IndexView.as_view(), name='index'),
        url(r'^(?P<pk>[0-9]+)$', views.DetailView.as_view(), name='details'),
        url(r'^main/add/$', views.TeamMemberCreate.as_view(), name='TeamMember'),
        url(r'^main/(?P<pk>[0-9]+)/delete/$', views.TeamMemberDelete.as_view(), name = 'TeamMember-delete'),
        ]