using System.Collections.Generic;
using UnityEngine;

public class FlowerTornado : MonoBehaviour
{
	private class ParticleInfo
	{
		public float particle_life;

		public float particle_start_pos;

		public float particle_revo_range;

		public float particle_rotation_x;

		public float particle_rotation_y;

		public float particle_rotation_z;

		public float particle_twist_rotation;

		public float particle_dist;

		public float particle_gravity;

		public float particle_range;

		public float particle_spread_speed;

		public float particle_spread_accel;
	}

	private ParticleSystem pe;

	private ParticleSystem.Particle[] particle;

	public int particle_total;

	public int start_particle_total;

	public float particle_appearance_interval;

	public float particle_appear_radius;

	public float particle_appear_radius_max;

	public float particle_thick;

	public float particle_spread;

	public float particle_radius_ellipse;

	public float appear_spread_time;

	public float appear_spread_speed;

	public bool particle_3D_rotation;

	public float particle_distortion;

	public float converge_radius_spread_time;

	public float converge_radius_spread_speed;

	public float converge_radius_max;

	public float anlgle_speed;

	public float anlgle_accel;

	public float anlgle_max_speed;

	public float circle_decrease_speed;

	public int add_particle_total;

	public float add_particle_time;

	public float gravity_start;

	public float gravity_accel;

	public float gravity_float;

	private int particle_num;

	private int numParticlesAlive;

	private float base_particle_angle;

	private float particule_appearance_time;

	private float converge_radius;

	private float base_particle_twist_angle;

	private float time;

	private int cut_num;

	private int cut_total;

	private List<ParticleInfo> particleInfos;

	private void Start()
	{
	}

	private void Update()
	{
	}

	private void particle_ini()
	{
	}

	private void particle_move()
	{
	}
}
