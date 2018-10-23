def _gapic_generator_codegen_impl(ctx):
  # @TODO (OP-3782) Remove this dependency on this output naming convention.
  if "gapicout" not in ctx.outputs.outs[0].path:
    fail("output directory must contain 'gapicout'")

  start = ctx.outputs.outs[0].path.find("gapicout")
  output_dir = ctx.outputs.outs[0].path[:start+len("gapicout")]

  args = [
      "--descriptor_set=" + ctx.file.descriptor_set.path,
      "--gapic_yaml=" + ctx.file.gapic_yaml.path,
      "--service_yaml=" + ctx.file.service_yaml.path,
      "--package_yaml2=" + ctx.file.package_yaml.path,
      "--output=" + output_dir,
  ]

  ctx.actions.run(
      inputs=[ctx.file.descriptor_set, ctx.file.gapic_yaml, ctx.file.service_yaml, ctx.file.package_yaml],
      outputs=ctx.outputs.outs,
      arguments=args,
      executable=ctx.executable._gapic_generator)

gapic_generator_codegen = rule(
  implementation=_gapic_generator_codegen_impl,
  attrs={
      "descriptor_set": attr.label(allow_single_file=True, mandatory=True),
      "gapic_yaml": attr.label(allow_single_file=True, mandatory=True),
      "service_yaml": attr.label(allow_single_file=True, mandatory=True),
      "package_yaml": attr.label(allow_single_file=True, mandatory=True),
      "outs": attr.output_list(mandatory=True, non_empty=True),
      "_gapic_generator": attr.label(executable=True, cfg="host", allow_files=True, default=Label("@gapic_generator//:gapic_generator"))
  },
  output_to_genfiles = True,
)

def paths(files):
  return [f.path for f in files]

def _impl(ctx):
  descriptors = ctx.attr.proto_library.proto.transitive_descriptor_sets
  ctx.actions.run_shell(
    inputs=descriptors,
    outputs=[ctx.outputs.out],
    command='cat %s > %s' % (
        ' '.join(paths(descriptors)), ctx.outputs.out.path))

proto_descriptor = rule(
  implementation=_impl,
  attrs = {
    "proto_library": attr.label(),
    "out": attr.output(mandatory=True),
  }
)