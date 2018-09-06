# Generated by the protocol buffer compiler.  DO NOT EDIT!
# source: grpcapi.proto

import sys
_b=sys.version_info[0]<3 and (lambda x:x) or (lambda x:x.encode('latin1'))
from google.protobuf.internal import enum_type_wrapper
from google.protobuf import descriptor as _descriptor
from google.protobuf import message as _message
from google.protobuf import reflection as _reflection
from google.protobuf import symbol_database as _symbol_database
from google.protobuf import descriptor_pb2
# @@protoc_insertion_point(imports)

_sym_db = _symbol_database.Default()




DESCRIPTOR = _descriptor.FileDescriptor(
  name='grpcapi.proto',
  package='pasapi',
  syntax='proto3',
  serialized_pb=_b('\n\rgrpcapi.proto\x12\x06pasapi\"\x1f\n\x0e\x44\x65\x65pPingOutput\x12\r\n\x05value\x18\x01 \x01(\t\"\x86\x01\n\x1bSetPointAlarmThresholdInput\x12\x0f\n\x07node_id\x18\x01 \x01(\t\x12\x0f\n\x07user_id\x18\x02 \x01(\t\x12#\n\x04type\x18\x03 \x01(\x0e\x32\x15.pasapi.ThresholdType\x12 \n\x07overall\x18\x04 \x01(\x0b\x32\x0f.pasapi.Overall\"\x1e\n\x1cSetPointAlarmThresholdOutput\".\n\x1bGetPointAlarmThresholdInput\x12\x0f\n\x07node_id\x18\x01 \x01(\t\"e\n\x1cGetPointAlarmThresholdOutput\x12#\n\x04type\x18\x01 \x01(\x0e\x32\x15.pasapi.ThresholdType\x12 \n\x07overall\x18\x02 \x01(\x0b\x32\x0f.pasapi.Overall\"V\n\x18SetPointAlarmStatusInput\x12\x0f\n\x07node_id\x18\x01 \x01(\t\x12)\n\x0c\x61larm_status\x18\x02 \x01(\x0e\x32\x13.pasapi.AlarmStatus\"\x1b\n\x19SetPointAlarmStatusOutput\"+\n\x18GetPointAlarmStatusInput\x12\x0f\n\x07node_id\x18\x01 \x01(\t\"F\n\x19GetPointAlarmStatusOutput\x12)\n\x0c\x61larm_status\x18\x01 \x01(\x0e\x32\x13.pasapi.AlarmStatus\" \n\x1eGetPointAlarmStatusStreamInput\"]\n\x1fGetPointAlarmStatusStreamOutput\x12\x0f\n\x07node_id\x18\x01 \x01(\t\x12)\n\x0c\x61larm_status\x18\x02 \x01(\x0e\x32\x13.pasapi.AlarmStatus\"\x06\n\x04Void\"\x1d\n\x0c\x44oubleObject\x12\r\n\x05value\x18\x01 \x01(\x01\"\xaf\x01\n\x07Overall\x12(\n\nouter_high\x18\x01 \x01(\x0b\x32\x14.pasapi.DoubleObject\x12(\n\ninner_high\x18\x02 \x01(\x0b\x32\x14.pasapi.DoubleObject\x12\'\n\tinner_low\x18\x03 \x01(\x0b\x32\x14.pasapi.DoubleObject\x12\'\n\touter_low\x18\x04 \x01(\x0b\x32\x14.pasapi.DoubleObject*O\n\x0b\x41larmStatus\x12\x12\n\x0eNOT_CONFIGURED\x10\x00\x12\x0b\n\x07NO_DATA\x10\x01\x12\x08\n\x04GOOD\x10\x02\x12\t\n\x05\x41LERT\x10\x03\x12\n\n\x06\x44\x41NGER\x10\x04*K\n\rThresholdType\x12\x08\n\x04NONE\x10\x00\x12\x15\n\x11OVERALL_IN_WINDOW\x10\x01\x12\x19\n\x15OVERALL_OUT_OF_WINDOW\x10\x02\x32\xc2\x04\n\x10PointAlarmStatus\x12\x32\n\x08\x44\x65\x65pPing\x12\x0c.pasapi.Void\x1a\x16.pasapi.DeepPingOutput\"\x00\x12\x65\n\x16SetPointAlarmThreshold\x12#.pasapi.SetPointAlarmThresholdInput\x1a$.pasapi.SetPointAlarmThresholdOutput\"\x00\x12\x65\n\x16GetPointAlarmThreshold\x12#.pasapi.GetPointAlarmThresholdInput\x1a$.pasapi.GetPointAlarmThresholdOutput\"\x00\x12\\\n\x13SetPointAlarmStatus\x12 .pasapi.SetPointAlarmStatusInput\x1a!.pasapi.SetPointAlarmStatusOutput\"\x00\x12\\\n\x13GetPointAlarmStatus\x12 .pasapi.GetPointAlarmStatusInput\x1a!.pasapi.GetPointAlarmStatusOutput\"\x00\x12p\n\x19GetPointAlarmStatusStream\x12&.pasapi.GetPointAlarmStatusStreamInput\x1a\'.pasapi.GetPointAlarmStatusStreamOutput\"\x00\x30\x01\x42\x16\xaa\x02\x13SKF.Enlight.API.PASb\x06proto3')
)

_ALARMSTATUS = _descriptor.EnumDescriptor(
  name='AlarmStatus',
  full_name='pasapi.AlarmStatus',
  filename=None,
  file=DESCRIPTOR,
  values=[
    _descriptor.EnumValueDescriptor(
      name='NOT_CONFIGURED', index=0, number=0,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='NO_DATA', index=1, number=1,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='GOOD', index=2, number=2,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='ALERT', index=3, number=3,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='DANGER', index=4, number=4,
      options=None,
      type=None),
  ],
  containing_type=None,
  options=None,
  serialized_start=958,
  serialized_end=1037,
)
_sym_db.RegisterEnumDescriptor(_ALARMSTATUS)

AlarmStatus = enum_type_wrapper.EnumTypeWrapper(_ALARMSTATUS)
_THRESHOLDTYPE = _descriptor.EnumDescriptor(
  name='ThresholdType',
  full_name='pasapi.ThresholdType',
  filename=None,
  file=DESCRIPTOR,
  values=[
    _descriptor.EnumValueDescriptor(
      name='NONE', index=0, number=0,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='OVERALL_IN_WINDOW', index=1, number=1,
      options=None,
      type=None),
    _descriptor.EnumValueDescriptor(
      name='OVERALL_OUT_OF_WINDOW', index=2, number=2,
      options=None,
      type=None),
  ],
  containing_type=None,
  options=None,
  serialized_start=1039,
  serialized_end=1114,
)
_sym_db.RegisterEnumDescriptor(_THRESHOLDTYPE)

ThresholdType = enum_type_wrapper.EnumTypeWrapper(_THRESHOLDTYPE)
NOT_CONFIGURED = 0
NO_DATA = 1
GOOD = 2
ALERT = 3
DANGER = 4
NONE = 0
OVERALL_IN_WINDOW = 1
OVERALL_OUT_OF_WINDOW = 2



_DEEPPINGOUTPUT = _descriptor.Descriptor(
  name='DeepPingOutput',
  full_name='pasapi.DeepPingOutput',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='value', full_name='pasapi.DeepPingOutput.value', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=25,
  serialized_end=56,
)


_SETPOINTALARMTHRESHOLDINPUT = _descriptor.Descriptor(
  name='SetPointAlarmThresholdInput',
  full_name='pasapi.SetPointAlarmThresholdInput',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='node_id', full_name='pasapi.SetPointAlarmThresholdInput.node_id', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='user_id', full_name='pasapi.SetPointAlarmThresholdInput.user_id', index=1,
      number=2, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='type', full_name='pasapi.SetPointAlarmThresholdInput.type', index=2,
      number=3, type=14, cpp_type=8, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='overall', full_name='pasapi.SetPointAlarmThresholdInput.overall', index=3,
      number=4, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=59,
  serialized_end=193,
)


_SETPOINTALARMTHRESHOLDOUTPUT = _descriptor.Descriptor(
  name='SetPointAlarmThresholdOutput',
  full_name='pasapi.SetPointAlarmThresholdOutput',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=195,
  serialized_end=225,
)


_GETPOINTALARMTHRESHOLDINPUT = _descriptor.Descriptor(
  name='GetPointAlarmThresholdInput',
  full_name='pasapi.GetPointAlarmThresholdInput',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='node_id', full_name='pasapi.GetPointAlarmThresholdInput.node_id', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=227,
  serialized_end=273,
)


_GETPOINTALARMTHRESHOLDOUTPUT = _descriptor.Descriptor(
  name='GetPointAlarmThresholdOutput',
  full_name='pasapi.GetPointAlarmThresholdOutput',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='type', full_name='pasapi.GetPointAlarmThresholdOutput.type', index=0,
      number=1, type=14, cpp_type=8, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='overall', full_name='pasapi.GetPointAlarmThresholdOutput.overall', index=1,
      number=2, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=275,
  serialized_end=376,
)


_SETPOINTALARMSTATUSINPUT = _descriptor.Descriptor(
  name='SetPointAlarmStatusInput',
  full_name='pasapi.SetPointAlarmStatusInput',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='node_id', full_name='pasapi.SetPointAlarmStatusInput.node_id', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='alarm_status', full_name='pasapi.SetPointAlarmStatusInput.alarm_status', index=1,
      number=2, type=14, cpp_type=8, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=378,
  serialized_end=464,
)


_SETPOINTALARMSTATUSOUTPUT = _descriptor.Descriptor(
  name='SetPointAlarmStatusOutput',
  full_name='pasapi.SetPointAlarmStatusOutput',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=466,
  serialized_end=493,
)


_GETPOINTALARMSTATUSINPUT = _descriptor.Descriptor(
  name='GetPointAlarmStatusInput',
  full_name='pasapi.GetPointAlarmStatusInput',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='node_id', full_name='pasapi.GetPointAlarmStatusInput.node_id', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=495,
  serialized_end=538,
)


_GETPOINTALARMSTATUSOUTPUT = _descriptor.Descriptor(
  name='GetPointAlarmStatusOutput',
  full_name='pasapi.GetPointAlarmStatusOutput',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='alarm_status', full_name='pasapi.GetPointAlarmStatusOutput.alarm_status', index=0,
      number=1, type=14, cpp_type=8, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=540,
  serialized_end=610,
)


_GETPOINTALARMSTATUSSTREAMINPUT = _descriptor.Descriptor(
  name='GetPointAlarmStatusStreamInput',
  full_name='pasapi.GetPointAlarmStatusStreamInput',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=612,
  serialized_end=644,
)


_GETPOINTALARMSTATUSSTREAMOUTPUT = _descriptor.Descriptor(
  name='GetPointAlarmStatusStreamOutput',
  full_name='pasapi.GetPointAlarmStatusStreamOutput',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='node_id', full_name='pasapi.GetPointAlarmStatusStreamOutput.node_id', index=0,
      number=1, type=9, cpp_type=9, label=1,
      has_default_value=False, default_value=_b("").decode('utf-8'),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='alarm_status', full_name='pasapi.GetPointAlarmStatusStreamOutput.alarm_status', index=1,
      number=2, type=14, cpp_type=8, label=1,
      has_default_value=False, default_value=0,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=646,
  serialized_end=739,
)


_VOID = _descriptor.Descriptor(
  name='Void',
  full_name='pasapi.Void',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=741,
  serialized_end=747,
)


_DOUBLEOBJECT = _descriptor.Descriptor(
  name='DoubleObject',
  full_name='pasapi.DoubleObject',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='value', full_name='pasapi.DoubleObject.value', index=0,
      number=1, type=1, cpp_type=5, label=1,
      has_default_value=False, default_value=float(0),
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=749,
  serialized_end=778,
)


_OVERALL = _descriptor.Descriptor(
  name='Overall',
  full_name='pasapi.Overall',
  filename=None,
  file=DESCRIPTOR,
  containing_type=None,
  fields=[
    _descriptor.FieldDescriptor(
      name='outer_high', full_name='pasapi.Overall.outer_high', index=0,
      number=1, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='inner_high', full_name='pasapi.Overall.inner_high', index=1,
      number=2, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='inner_low', full_name='pasapi.Overall.inner_low', index=2,
      number=3, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
    _descriptor.FieldDescriptor(
      name='outer_low', full_name='pasapi.Overall.outer_low', index=3,
      number=4, type=11, cpp_type=10, label=1,
      has_default_value=False, default_value=None,
      message_type=None, enum_type=None, containing_type=None,
      is_extension=False, extension_scope=None,
      options=None, file=DESCRIPTOR),
  ],
  extensions=[
  ],
  nested_types=[],
  enum_types=[
  ],
  options=None,
  is_extendable=False,
  syntax='proto3',
  extension_ranges=[],
  oneofs=[
  ],
  serialized_start=781,
  serialized_end=956,
)

_SETPOINTALARMTHRESHOLDINPUT.fields_by_name['type'].enum_type = _THRESHOLDTYPE
_SETPOINTALARMTHRESHOLDINPUT.fields_by_name['overall'].message_type = _OVERALL
_GETPOINTALARMTHRESHOLDOUTPUT.fields_by_name['type'].enum_type = _THRESHOLDTYPE
_GETPOINTALARMTHRESHOLDOUTPUT.fields_by_name['overall'].message_type = _OVERALL
_SETPOINTALARMSTATUSINPUT.fields_by_name['alarm_status'].enum_type = _ALARMSTATUS
_GETPOINTALARMSTATUSOUTPUT.fields_by_name['alarm_status'].enum_type = _ALARMSTATUS
_GETPOINTALARMSTATUSSTREAMOUTPUT.fields_by_name['alarm_status'].enum_type = _ALARMSTATUS
_OVERALL.fields_by_name['outer_high'].message_type = _DOUBLEOBJECT
_OVERALL.fields_by_name['inner_high'].message_type = _DOUBLEOBJECT
_OVERALL.fields_by_name['inner_low'].message_type = _DOUBLEOBJECT
_OVERALL.fields_by_name['outer_low'].message_type = _DOUBLEOBJECT
DESCRIPTOR.message_types_by_name['DeepPingOutput'] = _DEEPPINGOUTPUT
DESCRIPTOR.message_types_by_name['SetPointAlarmThresholdInput'] = _SETPOINTALARMTHRESHOLDINPUT
DESCRIPTOR.message_types_by_name['SetPointAlarmThresholdOutput'] = _SETPOINTALARMTHRESHOLDOUTPUT
DESCRIPTOR.message_types_by_name['GetPointAlarmThresholdInput'] = _GETPOINTALARMTHRESHOLDINPUT
DESCRIPTOR.message_types_by_name['GetPointAlarmThresholdOutput'] = _GETPOINTALARMTHRESHOLDOUTPUT
DESCRIPTOR.message_types_by_name['SetPointAlarmStatusInput'] = _SETPOINTALARMSTATUSINPUT
DESCRIPTOR.message_types_by_name['SetPointAlarmStatusOutput'] = _SETPOINTALARMSTATUSOUTPUT
DESCRIPTOR.message_types_by_name['GetPointAlarmStatusInput'] = _GETPOINTALARMSTATUSINPUT
DESCRIPTOR.message_types_by_name['GetPointAlarmStatusOutput'] = _GETPOINTALARMSTATUSOUTPUT
DESCRIPTOR.message_types_by_name['GetPointAlarmStatusStreamInput'] = _GETPOINTALARMSTATUSSTREAMINPUT
DESCRIPTOR.message_types_by_name['GetPointAlarmStatusStreamOutput'] = _GETPOINTALARMSTATUSSTREAMOUTPUT
DESCRIPTOR.message_types_by_name['Void'] = _VOID
DESCRIPTOR.message_types_by_name['DoubleObject'] = _DOUBLEOBJECT
DESCRIPTOR.message_types_by_name['Overall'] = _OVERALL
DESCRIPTOR.enum_types_by_name['AlarmStatus'] = _ALARMSTATUS
DESCRIPTOR.enum_types_by_name['ThresholdType'] = _THRESHOLDTYPE
_sym_db.RegisterFileDescriptor(DESCRIPTOR)

DeepPingOutput = _reflection.GeneratedProtocolMessageType('DeepPingOutput', (_message.Message,), dict(
  DESCRIPTOR = _DEEPPINGOUTPUT,
  __module__ = 'grpcapi_pb2'
  # @@protoc_insertion_point(class_scope:pasapi.DeepPingOutput)
  ))
_sym_db.RegisterMessage(DeepPingOutput)

SetPointAlarmThresholdInput = _reflection.GeneratedProtocolMessageType('SetPointAlarmThresholdInput', (_message.Message,), dict(
  DESCRIPTOR = _SETPOINTALARMTHRESHOLDINPUT,
  __module__ = 'grpcapi_pb2'
  # @@protoc_insertion_point(class_scope:pasapi.SetPointAlarmThresholdInput)
  ))
_sym_db.RegisterMessage(SetPointAlarmThresholdInput)

SetPointAlarmThresholdOutput = _reflection.GeneratedProtocolMessageType('SetPointAlarmThresholdOutput', (_message.Message,), dict(
  DESCRIPTOR = _SETPOINTALARMTHRESHOLDOUTPUT,
  __module__ = 'grpcapi_pb2'
  # @@protoc_insertion_point(class_scope:pasapi.SetPointAlarmThresholdOutput)
  ))
_sym_db.RegisterMessage(SetPointAlarmThresholdOutput)

GetPointAlarmThresholdInput = _reflection.GeneratedProtocolMessageType('GetPointAlarmThresholdInput', (_message.Message,), dict(
  DESCRIPTOR = _GETPOINTALARMTHRESHOLDINPUT,
  __module__ = 'grpcapi_pb2'
  # @@protoc_insertion_point(class_scope:pasapi.GetPointAlarmThresholdInput)
  ))
_sym_db.RegisterMessage(GetPointAlarmThresholdInput)

GetPointAlarmThresholdOutput = _reflection.GeneratedProtocolMessageType('GetPointAlarmThresholdOutput', (_message.Message,), dict(
  DESCRIPTOR = _GETPOINTALARMTHRESHOLDOUTPUT,
  __module__ = 'grpcapi_pb2'
  # @@protoc_insertion_point(class_scope:pasapi.GetPointAlarmThresholdOutput)
  ))
_sym_db.RegisterMessage(GetPointAlarmThresholdOutput)

SetPointAlarmStatusInput = _reflection.GeneratedProtocolMessageType('SetPointAlarmStatusInput', (_message.Message,), dict(
  DESCRIPTOR = _SETPOINTALARMSTATUSINPUT,
  __module__ = 'grpcapi_pb2'
  # @@protoc_insertion_point(class_scope:pasapi.SetPointAlarmStatusInput)
  ))
_sym_db.RegisterMessage(SetPointAlarmStatusInput)

SetPointAlarmStatusOutput = _reflection.GeneratedProtocolMessageType('SetPointAlarmStatusOutput', (_message.Message,), dict(
  DESCRIPTOR = _SETPOINTALARMSTATUSOUTPUT,
  __module__ = 'grpcapi_pb2'
  # @@protoc_insertion_point(class_scope:pasapi.SetPointAlarmStatusOutput)
  ))
_sym_db.RegisterMessage(SetPointAlarmStatusOutput)

GetPointAlarmStatusInput = _reflection.GeneratedProtocolMessageType('GetPointAlarmStatusInput', (_message.Message,), dict(
  DESCRIPTOR = _GETPOINTALARMSTATUSINPUT,
  __module__ = 'grpcapi_pb2'
  # @@protoc_insertion_point(class_scope:pasapi.GetPointAlarmStatusInput)
  ))
_sym_db.RegisterMessage(GetPointAlarmStatusInput)

GetPointAlarmStatusOutput = _reflection.GeneratedProtocolMessageType('GetPointAlarmStatusOutput', (_message.Message,), dict(
  DESCRIPTOR = _GETPOINTALARMSTATUSOUTPUT,
  __module__ = 'grpcapi_pb2'
  # @@protoc_insertion_point(class_scope:pasapi.GetPointAlarmStatusOutput)
  ))
_sym_db.RegisterMessage(GetPointAlarmStatusOutput)

GetPointAlarmStatusStreamInput = _reflection.GeneratedProtocolMessageType('GetPointAlarmStatusStreamInput', (_message.Message,), dict(
  DESCRIPTOR = _GETPOINTALARMSTATUSSTREAMINPUT,
  __module__ = 'grpcapi_pb2'
  # @@protoc_insertion_point(class_scope:pasapi.GetPointAlarmStatusStreamInput)
  ))
_sym_db.RegisterMessage(GetPointAlarmStatusStreamInput)

GetPointAlarmStatusStreamOutput = _reflection.GeneratedProtocolMessageType('GetPointAlarmStatusStreamOutput', (_message.Message,), dict(
  DESCRIPTOR = _GETPOINTALARMSTATUSSTREAMOUTPUT,
  __module__ = 'grpcapi_pb2'
  # @@protoc_insertion_point(class_scope:pasapi.GetPointAlarmStatusStreamOutput)
  ))
_sym_db.RegisterMessage(GetPointAlarmStatusStreamOutput)

Void = _reflection.GeneratedProtocolMessageType('Void', (_message.Message,), dict(
  DESCRIPTOR = _VOID,
  __module__ = 'grpcapi_pb2'
  # @@protoc_insertion_point(class_scope:pasapi.Void)
  ))
_sym_db.RegisterMessage(Void)

DoubleObject = _reflection.GeneratedProtocolMessageType('DoubleObject', (_message.Message,), dict(
  DESCRIPTOR = _DOUBLEOBJECT,
  __module__ = 'grpcapi_pb2'
  # @@protoc_insertion_point(class_scope:pasapi.DoubleObject)
  ))
_sym_db.RegisterMessage(DoubleObject)

Overall = _reflection.GeneratedProtocolMessageType('Overall', (_message.Message,), dict(
  DESCRIPTOR = _OVERALL,
  __module__ = 'grpcapi_pb2'
  # @@protoc_insertion_point(class_scope:pasapi.Overall)
  ))
_sym_db.RegisterMessage(Overall)


DESCRIPTOR.has_options = True
DESCRIPTOR._options = _descriptor._ParseOptions(descriptor_pb2.FileOptions(), _b('\252\002\023SKF.Enlight.API.PAS'))

_POINTALARMSTATUS = _descriptor.ServiceDescriptor(
  name='PointAlarmStatus',
  full_name='pasapi.PointAlarmStatus',
  file=DESCRIPTOR,
  index=0,
  options=None,
  serialized_start=1117,
  serialized_end=1695,
  methods=[
  _descriptor.MethodDescriptor(
    name='DeepPing',
    full_name='pasapi.PointAlarmStatus.DeepPing',
    index=0,
    containing_service=None,
    input_type=_VOID,
    output_type=_DEEPPINGOUTPUT,
    options=None,
  ),
  _descriptor.MethodDescriptor(
    name='SetPointAlarmThreshold',
    full_name='pasapi.PointAlarmStatus.SetPointAlarmThreshold',
    index=1,
    containing_service=None,
    input_type=_SETPOINTALARMTHRESHOLDINPUT,
    output_type=_SETPOINTALARMTHRESHOLDOUTPUT,
    options=None,
  ),
  _descriptor.MethodDescriptor(
    name='GetPointAlarmThreshold',
    full_name='pasapi.PointAlarmStatus.GetPointAlarmThreshold',
    index=2,
    containing_service=None,
    input_type=_GETPOINTALARMTHRESHOLDINPUT,
    output_type=_GETPOINTALARMTHRESHOLDOUTPUT,
    options=None,
  ),
  _descriptor.MethodDescriptor(
    name='SetPointAlarmStatus',
    full_name='pasapi.PointAlarmStatus.SetPointAlarmStatus',
    index=3,
    containing_service=None,
    input_type=_SETPOINTALARMSTATUSINPUT,
    output_type=_SETPOINTALARMSTATUSOUTPUT,
    options=None,
  ),
  _descriptor.MethodDescriptor(
    name='GetPointAlarmStatus',
    full_name='pasapi.PointAlarmStatus.GetPointAlarmStatus',
    index=4,
    containing_service=None,
    input_type=_GETPOINTALARMSTATUSINPUT,
    output_type=_GETPOINTALARMSTATUSOUTPUT,
    options=None,
  ),
  _descriptor.MethodDescriptor(
    name='GetPointAlarmStatusStream',
    full_name='pasapi.PointAlarmStatus.GetPointAlarmStatusStream',
    index=5,
    containing_service=None,
    input_type=_GETPOINTALARMSTATUSSTREAMINPUT,
    output_type=_GETPOINTALARMSTATUSSTREAMOUTPUT,
    options=None,
  ),
])
_sym_db.RegisterServiceDescriptor(_POINTALARMSTATUS)

DESCRIPTOR.services_by_name['PointAlarmStatus'] = _POINTALARMSTATUS

# @@protoc_insertion_point(module_scope)
