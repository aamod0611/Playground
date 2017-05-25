from django.views import generic
from django.views.generic.edit import CreateView, DeleteView,UpdateView
from django.core.urlresolvers import reverse_lazy
from . models import TeamMembers, Teams, CciGroups
from django.db.models.deletion import ProtectedError
from django.contrib.messages import constants as messages

class IndexView(generic.ListView):
    template_name = 'index.html'
    context_object_name = 'all_album'

    def get_queryset(self):
        return TeamMembers.objects.all()


class DetailView(generic.DetailView):
    model = TeamMembers
    context_object_name = 'TeamMembers'
    template_name = 'details.html'


class TeamMemberCreate(CreateView):
    model = TeamMembers
    template_name = 'TeamMember_form.html'
    fields = ['Name', 'DOB', 'Designation', 'Pic', 'Team']

class TeamMemberUpdate(UpdateView):
    model = TeamMembers
    template_name = 'TeamMember_form.html'
    fields = ['Name', 'DOB', 'Designation', 'Pic', 'Team']


class TeamMemberDelete(DeleteView):
    model = TeamMembers
    success_url = reverse_lazy('main:index')


class TeamsCreate(CreateView):
    model = Teams
    template_name = 'Teams_form.html'
    fields = ['TeamName', 'TeamLead', 'ClientName', 'Tech','Group']

class TeamUpdate(UpdateView):
    model = Teams
    template_name = 'Teams_form.html'
    fields = ['TeamName', 'TeamLead', 'ClientName', 'Tech','Group']



class TeamDetailView(generic.DetailView):
    model = Teams
    context_object_name = 'TeamsDetail'
    template_name = 'TeamDetails.html'

    def get_context_data(self, **kwargs):
        context = super(TeamDetailView, self).get_context_data(**kwargs)
        context['All_TeamMembers'] = TeamMembers.objects.filter(Team_id=self.kwargs['pk'])
        return context


class TeamMemberDetailView(generic.DetailView):
    model = TeamMembers
    context_object_name = 'TeamMembers'
    template_name = 'TeamDetails.html'


class TeamView(generic.ListView):
    template_name = 'AllTeams.html'
    context_object_name = 'teams'

    def get_queryset(self):
        return Teams.objects.all()


class TeamsDelete(DeleteView):
    try:
        model = Teams
        success_url = reverse_lazy('main:AllTeams')
    except ProtectedError as e:
        print(e)
        success_url = reverse_lazy('main:AllTeams')


class GroupCreate(CreateView):
    model = CciGroups
    template_name = 'Group_form.html'
    fields = ['GroupName']


class GroupView(generic.ListView):
    template_name = 'GroupDetails.html'
    context_object_name = 'GroupsDetail'

    def get_queryset(self):
        return CciGroups.objects.all()


class GroupDetailView(generic.DetailView):
    model = CciGroups
    context_object_name = 'Groups'
    template_name = 'GroupTeamDisplay.html'

    def get_context_data(self, **kwargs):
        context = super(GroupDetailView, self).get_context_data(**kwargs)
        context['GroupTeams'] = Teams.objects.filter(Group_id=self.kwargs['pk'])
        return context