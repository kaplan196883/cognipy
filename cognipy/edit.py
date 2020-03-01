import ipywidgets as widgets
from traitlets import Unicode, Int, validate
import os

from IPython.display import Javascript
from cognipy.ontology import Ontology

_JS_initialized = False
def _InitJS():
    global _JS_initialized
    if _JS_initialized:
        return
    with open(os.path.dirname(os.path.abspath(__file__))+"/edit.js", 'r') as file:
        _JS_initialized = True
        display( Javascript(file.read()) )
        
class OntoeditWidget(widgets.DOMWidget):
    _view_name = Unicode('OntoeditView').tag(sync=True)
    _model_name = Unicode('OntoeditModel').tag(sync=True)
    _view_module = Unicode('ontoedit').tag(sync=True)
    _model_module = Unicode('ontoedit').tag(sync=True)
    value = Unicode('').tag(sync=True)
    cursor = Int(0).tag(sync=True)
    hints = Unicode('').tag(sync=True)
    hintsX = Int(0).tag(sync=True)
    hintT = Unicode('').tag(sync=True) 
    

def escape(html):
    """Returns the given HTML with ampersands, quotes and carets encoded."""
    return html.replace('&', '&amp;').replace('<', '&lt;').replace('>', '&gt;').replace('"', '&quot;').replace("'", '&#39;')

from functools import reduce
def getcommonletters(strlist):
    return ''.join([x[0] for x in zip(*strlist) \
                     if reduce(lambda a,b:(a == b) and a or None,x)])

def findcommonstart(strlist):
    strlist = strlist[:]
    prev = None
    while True:
        common = getcommonletters(strlist)
        if common == prev:
            break
        strlist.append(common)
        prev = common

    return getcommonletters(strlist)

def CnlEditBox(snap_filename,onto = None):
    _InitJS()
    if onto is None:
        try:
            if not os.path.exists(snap_filename):
                onto = Ontology("cnl/string","Every thing is a thing.")
            else:
                onto = Ontology("cnl/file",snap_filename)
        except Exception as e:
            print(str(e))
            onto=None
        
    if not os.path.exists(snap_filename):
        open(snap_filename, 'a').close()

    def autoCompl(onto,s):
        pos=s.rfind('.', 0, len(s))
        pos=0 if pos<0 else pos+1
        inn=s[pos:len(s)].lstrip(' \n\t')
        ac= onto.autocomplete(inn)
        return ac

    def onChange(change):
#        print(change)
        if change.name=="value":
            while True:
                try:
                    with open(snap_filename, 'w') as file:
                        file.write(change.new)
                    break
                except:
                    continue
        elif change.name=="cursor": 
            s = change.owner.value[0:change.new]
            acl=[]
            if onto is None:
                acl=['!!!SYNTAX ERROR!!!']
            else:
                acl=autoCompl(onto,s)
                acl.sort()
            options=[escape(x) for x in acl]
            oopts = [o for o in acl if o[0]!='<']
            change.owner.hints="<br/>".join(options)
            pos = max(s.rfind(i) for i in [' ','\t', '\n', '.'])
            change.owner.hintsX=pos+1
            change.owner.hintT=findcommonstart(oopts)
                        
    txt = None
    with open(snap_filename, 'r') as file:
        txt = file.read()

    w=OntoeditWidget(
                    value = txt,
                    placeholder='Type something',
                    disabled=False,
                    layout=widgets.Layout(width='90%', height= '100%'),
                    style={'description_width': 'initial'}
                )
    o=widgets.Output()
    w.observe(onChange, names=['cursor','value'])
    xx= widgets.VBox([w,o], layout={'height': '300px'})
    xx.getvalue=lambda : w.value
    return xx

    
def CnlQueryForConcept(snap_filename,onto):
    _InitJS()
    if not os.path.exists(snap_filename):
        open(snap_filename, 'a').close()

    def autoCompl(onto,s):
        pos=s.rfind('.', 0, len(s))
        pos=0 if pos<0 else pos+1
        return onto.autocomplete("Every-single-thing that is "+s)

    def onChange(change):
#        print(change)
        if change.name=="value":
            while True:
                try:
                    with open(snap_filename, 'w') as file:
                        file.write(change.new)
                    break
                except:
                    continue
        elif change.name=="cursor": 
            s = change.owner.value[0:change.new]
            acl=autoCompl(onto,s)
            acl.sort()
            options=[escape(x) for x in acl]
            oopts = [o for o in acl if o[0]!='<']
            change.owner.hints="<br/>".join(options)
            pos = max(s.rfind(i) for i in [' ','\t', '\n', '.'])
            change.owner.hintsX=pos+1
            change.owner.hintT=findcommonstart(oopts)
                
    txt = None
    with open(snap_filename, 'r') as file:
        txt = file.read()

    w=OntoeditWidget(
                    value = txt,
                    placeholder='Type something',
                    disabled=False,
                    layout=widgets.Layout(width='90%', height= '100%'),
                    style={'description_width': 'initial'}
                )
    w.observe(onChange, names=['cursor','value'])
    o=widgets.Output()
    xx= widgets.VBox([w,o], layout={'height': '100px'})
    xx.getvalue=lambda : w.value
    return xx